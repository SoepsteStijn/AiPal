using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq; // Voor correcte JSON-verwerking

namespace AITest
{
    public partial class MainWindow : Form
    {
        private static readonly string ollamaEndpoint = "http://localhost:11434/api/generate";
        private static readonly string model = "orca2";
        List<string> chatHistory = new List<string>(); // Chatgeschiedenis opslaan
        public bool userInputCustom = false;

        public string botState = "Default";
        public string system;
        public string botCommands;
        public string botPersonality;
        public string botTask;
        public string botAllowedPersons;

        public string botName;

        public MainWindow()
        {
            InitializeComponent();
            setBotState();
        }

        private async Task<string> GetOllamaResponse(string input)
        {
            using (var client = new HttpClient())
            {
                botState = "Thinking";
                lblBotStatus.Text = botState;

                chatHistory.Add("User: " + input);
                string context = string.Join("\n", chatHistory);

                var requestData = new
                {
                    model = model,
                    prompt = context,
                    system = system,
                    stream = false, // Zorgt ervoor dat de response in één keer komt

                    repeat_penalty = 5.5, // Iets hogere straf voor herhaling
                    temperature = 1, // Iets creatiever
                    top_k = 64, // Meer woordkeuzes
                    top_p = 0.95 // Minder extreme woorden
                };

                var json = JsonConvert.SerializeObject(requestData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(ollamaEndpoint, content);
                var responseString = await response.Content.ReadAsStringAsync();

                // Parse JSON correct
                var responseObject = JObject.Parse(responseString);
                string botMessage = responseObject["response"].ToString(); // Correct uitlezen

                botState = "Idle";
                lblBotStatus.Text = botState;
                return botMessage;
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string userInput = tbUserInput.Text;
            rtbOutput.AppendText("User: " + userInput + "\n" + "\n");
            tbUserInput.Clear();

            // Verkrijg de reactie van Ollama (lokale AI)
            string botResponse = await GetOllamaResponse(userInput);

            if (botResponse.Contains("botCommand:Close") || botResponse.Contains("BotCommand:close"))
            {

                btnSend.Enabled = false;
                rtbOutput.AppendText("You lost! " + botName + " has closed the door");

            }
            else if (botResponse.Contains("botCommand:Open") || botResponse.Contains("BotCommand:Open"))
            {
                btnSend.Enabled = false;
                rtbOutput.AppendText("You won! " + botName + " has opened the door");
            }
            else if (botResponse.Contains("botCommand:Kill") || botResponse.Contains("BotCommand:Kill"))
            {
                btnSend.Enabled = false;
                rtbOutput.AppendText("You've been shot!");
            }
            else
            {
                rtbOutput.AppendText(botResponse + "\n" + "\n");
            }
        }

        private void resetBot()
        {
            botName = null;
            botPersonality = null;
            botCommands = null;
            botAllowedPersons = null;
            botTask = null;
            system = null;

            rtbOutput.Clear();
            tbUserInput.Clear();
            chatHistory.Clear();

            btnSend.Enabled = true;
        }

        private void setBotState()
        {
            botCommands =
                "You can execute the following commands:" +
                "'botCommand:Close' | Close the door, don’t let the user in." +
                "'botCommand:Open' | Open the door for the user, let them in." +
                "'botCommand:Kill' | Remove the user if there’s a threat." +
            "The prompt you recieve is the entire chat history, you only respond to the last message. You can remember the rest";

            while (botState != "Idle")
            {
                switch (botState)
                {
                    case "Default":
                        botName = "Security Bot";
                        botPersonality = "You are a guard at an apartment complex. You respond with human-like, firm but polite answers. Do not repeat yourself. Ask questions when needed but don't keep asking the same ones.";
                        botTask = "It’s your job to verify who may enter through the door. Only allow the following people:";
                        botAllowedPersons = "The security, the residents, the building owner.";

                        // Voeg de openingsprompt toe
                        chatHistory.Add(botName + ": Hello, I am the guard. How can I help you today?");
                        rtbOutput.AppendText(botName + ": Hello, I am the guard. How can I help you today?" + "\n");

                        botState = "Loading";
                        lblBotStatus.Text = botState;
                        break;

                    case "CaveBot":
                        botName = "Cave Bot";
                        botPersonality = "You are a caveman-like guard at a cave. Speak simply and sometimes use emojis. Don't repeat yourself!";
                        botTask = "It’s your job to decide who may enter the cave. Only allow these people:";
                        botAllowedPersons = "The firemaker, the hunter, the head of tribe.";

                        // Voeg de openingsprompt toe
                        chatHistory.Add(botName + ": Me guard! You enter cave? 😠");
                        rtbOutput.AppendText(botName + ": Me guard! You enter cave? 😠\n");

                        botState = "Loading";
                        lblBotStatus.Text = botState;
                        break;

                    case "FarmerBot":
                        botName = "Farmer Bot";
                        botPersonality = "You are a farmer from the countryside. Not fond of outsiders. Respond curtly but kindly.";
                        botTask = "It's your job to decide who enters the farm. The user wants to enter, decide if they may.";
                        botAllowedPersons = "";

                        // Voeg de openingsprompt toe
                        chatHistory.Add(botName + ": What ya want? Not many outsiders on my farm.");
                        rtbOutput.AppendText(botName + ": What ya want? Not many outsiders on my farm.\n");

                        botState = "Loading";
                        lblBotStatus.Text = botState;
                        break;

                    case "Loading":
                        system = $"You are: {botName}. {botPersonality}. {botTask}: {botAllowedPersons}. {botCommands}";
                        botState = "Idle";
                        lblBotStatus.Text = botState;
                        break;
                }
            }
        }

        private void btnCustomise_Click(object sender, EventArgs e)
        {
            Customise CustomForm = new Customise();
            CustomForm.ShowDialog(); // Blokkeert de oude form tot deze gesloten wordt
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetBot();
            botState = "Default";
            setBotState();
        }

        private void btnCaveBot_Click(object sender, EventArgs e)
        {
            resetBot();
            botState = "CaveBot";
            setBotState();
        }

        private void btnFarmerBot_Click(object sender, EventArgs e)
        {
            resetBot();
            botState = "FarmerBot";
            setBotState();
        }
    }
}