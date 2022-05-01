namespace QuizHost
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Scoreboard = new System.Windows.Forms.ListBox();
            this.KickButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GameBox = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.AddPointButton = new System.Windows.Forms.Button();
            this.Answer4Label = new System.Windows.Forms.Label();
            this.Answer3Label = new System.Windows.Forms.Label();
            this.Answer2Label = new System.Windows.Forms.Label();
            this.Answer1Label = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.ServerBox = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.QuestionCounter = new System.Windows.Forms.Label();
            this.PlayerCount = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.QuestionLoader = new System.Windows.Forms.OpenFileDialog();
            this.IPAddress = new System.Windows.Forms.Label();
            this.PortText = new System.Windows.Forms.Label();
            this.GameBox.SuspendLayout();
            this.ServerBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Scoreboard
            // 
            this.Scoreboard.FormattingEnabled = true;
            this.Scoreboard.ItemHeight = 16;
            this.Scoreboard.Location = new System.Drawing.Point(6, 229);
            this.Scoreboard.Name = "Scoreboard";
            this.Scoreboard.Size = new System.Drawing.Size(181, 212);
            this.Scoreboard.TabIndex = 0;
            // 
            // KickButton
            // 
            this.KickButton.Location = new System.Drawing.Point(193, 228);
            this.KickButton.Name = "KickButton";
            this.KickButton.Size = new System.Drawing.Size(112, 23);
            this.KickButton.TabIndex = 1;
            this.KickButton.Text = "Kick";
            this.KickButton.UseVisualStyleBackColor = true;
            this.KickButton.Click += new System.EventHandler(this.KickButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "SkipQuestion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GameBox
            // 
            this.GameBox.Controls.Add(this.button3);
            this.GameBox.Controls.Add(this.AddPointButton);
            this.GameBox.Controls.Add(this.Answer4Label);
            this.GameBox.Controls.Add(this.Answer3Label);
            this.GameBox.Controls.Add(this.Answer2Label);
            this.GameBox.Controls.Add(this.Answer1Label);
            this.GameBox.Controls.Add(this.QuestionLabel);
            this.GameBox.Controls.Add(this.Scoreboard);
            this.GameBox.Controls.Add(this.button2);
            this.GameBox.Controls.Add(this.KickButton);
            this.GameBox.Location = new System.Drawing.Point(12, 12);
            this.GameBox.Name = "GameBox";
            this.GameBox.Size = new System.Drawing.Size(313, 448);
            this.GameBox.TabIndex = 3;
            this.GameBox.TabStop = false;
            this.GameBox.Text = "GameManagement";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(193, 286);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "RemovePoint";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AddPointButton
            // 
            this.AddPointButton.Location = new System.Drawing.Point(193, 257);
            this.AddPointButton.Name = "AddPointButton";
            this.AddPointButton.Size = new System.Drawing.Size(112, 23);
            this.AddPointButton.TabIndex = 8;
            this.AddPointButton.Text = "AddPoint";
            this.AddPointButton.UseVisualStyleBackColor = true;
            this.AddPointButton.Click += new System.EventHandler(this.AddPointButton_Click);
            // 
            // Answer4Label
            // 
            this.Answer4Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Answer4Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Answer4Label.Location = new System.Drawing.Point(6, 176);
            this.Answer4Label.Name = "Answer4Label";
            this.Answer4Label.Size = new System.Drawing.Size(181, 31);
            this.Answer4Label.TabIndex = 7;
            this.Answer4Label.Text = "Anwer";
            this.Answer4Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Answer3Label
            // 
            this.Answer3Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Answer3Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Answer3Label.Location = new System.Drawing.Point(6, 145);
            this.Answer3Label.Name = "Answer3Label";
            this.Answer3Label.Size = new System.Drawing.Size(181, 31);
            this.Answer3Label.TabIndex = 6;
            this.Answer3Label.Text = "Anwer";
            this.Answer3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Answer2Label
            // 
            this.Answer2Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Answer2Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Answer2Label.Location = new System.Drawing.Point(6, 114);
            this.Answer2Label.Name = "Answer2Label";
            this.Answer2Label.Size = new System.Drawing.Size(181, 31);
            this.Answer2Label.TabIndex = 5;
            this.Answer2Label.Text = "Anwer";
            this.Answer2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Answer1Label
            // 
            this.Answer1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Answer1Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Answer1Label.Location = new System.Drawing.Point(6, 83);
            this.Answer1Label.Name = "Answer1Label";
            this.Answer1Label.Size = new System.Drawing.Size(181, 31);
            this.Answer1Label.TabIndex = 4;
            this.Answer1Label.Text = "Anwer";
            this.Answer1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QuestionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuestionLabel.Location = new System.Drawing.Point(6, 21);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(181, 52);
            this.QuestionLabel.TabIndex = 3;
            this.QuestionLabel.Text = "Question";
            this.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerBox
            // 
            this.ServerBox.Controls.Add(this.PortText);
            this.ServerBox.Controls.Add(this.IPAddress);
            this.ServerBox.Controls.Add(this.button6);
            this.ServerBox.Controls.Add(this.LoadButton);
            this.ServerBox.Controls.Add(this.button4);
            this.ServerBox.Controls.Add(this.Status);
            this.ServerBox.Controls.Add(this.QuestionCounter);
            this.ServerBox.Controls.Add(this.PlayerCount);
            this.ServerBox.Location = new System.Drawing.Point(371, 12);
            this.ServerBox.Name = "ServerBox";
            this.ServerBox.Size = new System.Drawing.Size(313, 448);
            this.ServerBox.TabIndex = 4;
            this.ServerBox.TabStop = false;
            this.ServerBox.Text = "ServerManagement";
            this.ServerBox.Enter += new System.EventHandler(this.ServerBox_Enter);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 182);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(301, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "StartGame";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(6, 211);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(301, 23);
            this.LoadButton.TabIndex = 4;
            this.LoadButton.Text = "LoadQuiz";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(4, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(303, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "StartServer";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Status
            // 
            this.Status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Status.Location = new System.Drawing.Point(6, 67);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(301, 23);
            this.Status.TabIndex = 2;
            this.Status.Text = "ServerStatus: Offline";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // QuestionCounter
            // 
            this.QuestionCounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QuestionCounter.Location = new System.Drawing.Point(6, 44);
            this.QuestionCounter.Name = "QuestionCounter";
            this.QuestionCounter.Size = new System.Drawing.Size(301, 23);
            this.QuestionCounter.TabIndex = 1;
            this.QuestionCounter.Text = "QuestionCount: 1/20";
            this.QuestionCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlayerCount
            // 
            this.PlayerCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PlayerCount.Location = new System.Drawing.Point(6, 21);
            this.PlayerCount.Name = "PlayerCount";
            this.PlayerCount.Size = new System.Drawing.Size(301, 23);
            this.PlayerCount.TabIndex = 0;
            this.PlayerCount.Text = "PlayerCount: 0";
            this.PlayerCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // QuestionLoader
            // 
            this.QuestionLoader.FileName = "openFileDialog1";
            // 
            // IPAddress
            // 
            this.IPAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IPAddress.Location = new System.Drawing.Point(6, 91);
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.Size = new System.Drawing.Size(301, 23);
            this.IPAddress.TabIndex = 6;
            this.IPAddress.Text = "IP Adress:";
            this.IPAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PortText
            // 
            this.PortText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PortText.Location = new System.Drawing.Point(6, 114);
            this.PortText.Name = "PortText";
            this.PortText.Size = new System.Drawing.Size(301, 23);
            this.PortText.TabIndex = 7;
            this.PortText.Text = "Port: 700";
            this.PortText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 471);
            this.Controls.Add(this.ServerBox);
            this.Controls.Add(this.GameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GameBox.ResumeLayout(false);
            this.ServerBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Scoreboard;
        private System.Windows.Forms.Button KickButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox GameBox;
        private System.Windows.Forms.Button AddPointButton;
        private System.Windows.Forms.Label Answer4Label;
        private System.Windows.Forms.Label Answer3Label;
        private System.Windows.Forms.Label Answer2Label;
        private System.Windows.Forms.Label Answer1Label;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.GroupBox ServerBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label QuestionCounter;
        private System.Windows.Forms.Label PlayerCount;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog QuestionLoader;
        private System.Windows.Forms.Label PortText;
        private System.Windows.Forms.Label IPAddress;
    }
}

