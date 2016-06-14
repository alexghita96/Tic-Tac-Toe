namespace TicTacToe
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.Player1 = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Player1_Symbol = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Player1_Color = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Player2_Symbol = new System.Windows.Forms.ComboBox();
            this.Player2_Color = new System.Windows.Forms.ComboBox();
            this.Player1_Name = new System.Windows.Forms.TextBox();
            this.Player2_Name = new System.Windows.Forms.TextBox();
            this.RoundsNo = new System.Windows.Forms.TextBox();
            this.StartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Location = new System.Drawing.Point(12, 10);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(48, 13);
            this.Player1.TabIndex = 0;
            this.Player1.Text = "Player 1:";
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.Location = new System.Drawing.Point(12, 90);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(48, 13);
            this.Player2.TabIndex = 1;
            this.Player2.Text = "Player 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of Rounds:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Color:";
            // 
            // Player1_Symbol
            // 
            this.Player1_Symbol.FormattingEnabled = true;
            this.Player1_Symbol.Items.AddRange(new object[] {
            "X",
            "O"});
            this.Player1_Symbol.Location = new System.Drawing.Point(141, 32);
            this.Player1_Symbol.Name = "Player1_Symbol";
            this.Player1_Symbol.Size = new System.Drawing.Size(50, 21);
            this.Player1_Symbol.TabIndex = 7;
            this.Player1_Symbol.SelectedIndexChanged += new System.EventHandler(this.Player1_Symbol_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Color:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(70, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Player 1 always starts first!";
            // 
            // Player1_Color
            // 
            this.Player1_Color.FormattingEnabled = true;
            this.Player1_Color.Items.AddRange(new object[] {
            "Blue",
            "Green",
            "Red",
            "Yellow"});
            this.Player1_Color.Location = new System.Drawing.Point(141, 60);
            this.Player1_Color.Name = "Player1_Color";
            this.Player1_Color.Size = new System.Drawing.Size(121, 21);
            this.Player1_Color.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Symbol:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Symbol:";
            // 
            // Player2_Symbol
            // 
            this.Player2_Symbol.FormattingEnabled = true;
            this.Player2_Symbol.Items.AddRange(new object[] {
            "X",
            "O"});
            this.Player2_Symbol.Location = new System.Drawing.Point(141, 112);
            this.Player2_Symbol.Name = "Player2_Symbol";
            this.Player2_Symbol.Size = new System.Drawing.Size(50, 21);
            this.Player2_Symbol.TabIndex = 13;
            this.Player2_Symbol.SelectedIndexChanged += new System.EventHandler(this.Player2_Symbol_SelectedIndexChanged);
            // 
            // Player2_Color
            // 
            this.Player2_Color.FormattingEnabled = true;
            this.Player2_Color.Items.AddRange(new object[] {
            "Blue",
            "Green",
            "Red",
            "Yellow"});
            this.Player2_Color.Location = new System.Drawing.Point(141, 140);
            this.Player2_Color.Name = "Player2_Color";
            this.Player2_Color.Size = new System.Drawing.Size(121, 21);
            this.Player2_Color.TabIndex = 14;
            // 
            // Player1_Name
            // 
            this.Player1_Name.Location = new System.Drawing.Point(141, 7);
            this.Player1_Name.Name = "Player1_Name";
            this.Player1_Name.Size = new System.Drawing.Size(100, 20);
            this.Player1_Name.TabIndex = 15;
            // 
            // Player2_Name
            // 
            this.Player2_Name.Location = new System.Drawing.Point(141, 87);
            this.Player2_Name.Name = "Player2_Name";
            this.Player2_Name.Size = new System.Drawing.Size(100, 20);
            this.Player2_Name.TabIndex = 16;
            // 
            // RoundsNo
            // 
            this.RoundsNo.Location = new System.Drawing.Point(141, 167);
            this.RoundsNo.Name = "RoundsNo";
            this.RoundsNo.Size = new System.Drawing.Size(100, 20);
            this.RoundsNo.TabIndex = 17;
            // 
            // StartGame
            // 
            this.StartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.StartGame.Location = new System.Drawing.Point(100, 230);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(75, 23);
            this.StartGame.TabIndex = 18;
            this.StartGame.Text = "Start";
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.RoundsNo);
            this.Controls.Add(this.Player2_Name);
            this.Controls.Add(this.Player1_Name);
            this.Controls.Add(this.Player2_Color);
            this.Controls.Add(this.Player2_Symbol);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Player1_Color);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Player1_Symbol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Game Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.Label Player2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Player1_Symbol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Player1_Color;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Player2_Symbol;
        private System.Windows.Forms.ComboBox Player2_Color;
        private System.Windows.Forms.TextBox Player1_Name;
        private System.Windows.Forms.TextBox Player2_Name;
        private System.Windows.Forms.TextBox RoundsNo;
        private System.Windows.Forms.Button StartGame;
    }
}