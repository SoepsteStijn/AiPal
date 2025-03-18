namespace AITest
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbUserInput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBotStatus = new System.Windows.Forms.Label();
            this.btnCaveBot = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCustomise = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbOutput
            // 
            this.rtbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.rtbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbOutput.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOutput.ForeColor = System.Drawing.Color.White;
            this.rtbOutput.Location = new System.Drawing.Point(0, 0);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.Size = new System.Drawing.Size(715, 424);
            this.rtbOutput.TabIndex = 0;
            this.rtbOutput.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCaveBot);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnCustomise);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Location = new System.Drawing.Point(718, -4);
            this.panel1.MaximumSize = new System.Drawing.Size(171, 484);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(171, 484);
            this.panel1.TabIndex = 4;
            // 
            // tbUserInput
            // 
            this.tbUserInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.tbUserInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUserInput.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbUserInput.ForeColor = System.Drawing.Color.White;
            this.tbUserInput.Location = new System.Drawing.Point(0, 423);
            this.tbUserInput.Name = "tbUserInput";
            this.tbUserInput.Size = new System.Drawing.Size(715, 52);
            this.tbUserInput.TabIndex = 5;
            this.tbUserInput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(556, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "BotStatus: ";
            // 
            // lblBotStatus
            // 
            this.lblBotStatus.AutoSize = true;
            this.lblBotStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.lblBotStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBotStatus.ForeColor = System.Drawing.Color.White;
            this.lblBotStatus.Location = new System.Drawing.Point(637, 400);
            this.lblBotStatus.Name = "lblBotStatus";
            this.lblBotStatus.Size = new System.Drawing.Size(14, 20);
            this.lblBotStatus.TabIndex = 7;
            this.lblBotStatus.Text = "-";
            // 
            // btnCaveBot
            // 
            this.btnCaveBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCaveBot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaveBot.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCaveBot.FlatAppearance.BorderSize = 0;
            this.btnCaveBot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCaveBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaveBot.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaveBot.ForeColor = System.Drawing.Color.White;
            this.btnCaveBot.Image = global::AITest.Properties.Resources.cave;
            this.btnCaveBot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaveBot.Location = new System.Drawing.Point(-1, 129);
            this.btnCaveBot.Name = "btnCaveBot";
            this.btnCaveBot.Size = new System.Drawing.Size(169, 59);
            this.btnCaveBot.TabIndex = 5;
            this.btnCaveBot.Text = "Cave Bot";
            this.btnCaveBot.UseVisualStyleBackColor = false;
            this.btnCaveBot.Click += new System.EventHandler(this.btnCaveBot_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = global::AITest.Properties.Resources.verified;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(-1, 64);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(169, 59);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Security Bot";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCustomise
            // 
            this.btnCustomise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCustomise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomise.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCustomise.FlatAppearance.BorderSize = 0;
            this.btnCustomise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCustomise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomise.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomise.ForeColor = System.Drawing.Color.White;
            this.btnCustomise.Image = global::AITest.Properties.Resources.equalizer;
            this.btnCustomise.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomise.Location = new System.Drawing.Point(-1, 4);
            this.btnCustomise.Name = "btnCustomise";
            this.btnCustomise.Size = new System.Drawing.Size(169, 59);
            this.btnCustomise.TabIndex = 3;
            this.btnCustomise.Text = "Customise Bot";
            this.btnCustomise.UseVisualStyleBackColor = false;
            this.btnCustomise.Click += new System.EventHandler(this.btnCustomise_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Image = global::AITest.Properties.Resources.send;
            this.btnSend.Location = new System.Drawing.Point(0, 426);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(171, 54);
            this.btnSend.TabIndex = 2;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(885, 474);
            this.Controls.Add(this.lblBotStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUserInput);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(901, 513);
            this.MinimumSize = new System.Drawing.Size(901, 513);
            this.Name = "MainWindow";
            this.Text = "AiPal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCustomise;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox tbUserInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBotStatus;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCaveBot;
    }
}

