
namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_bottomLeft = new System.Windows.Forms.Button();
            this.btn_bottomCenter = new System.Windows.Forms.Button();
            this.btn_bottomRight = new System.Windows.Forms.Button();
            this.btn_centerRight = new System.Windows.Forms.Button();
            this.btn_centerCenter = new System.Windows.Forms.Button();
            this.btn_centerLeft = new System.Windows.Forms.Button();
            this.btn_topRight = new System.Windows.Forms.Button();
            this.btn_topCenter = new System.Windows.Forms.Button();
            this.btn_topLeft = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.MenuStrip();
            this.toolStripHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_NewGame = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.textBox_Score = new System.Windows.Forms.TextBox();
            this.textBox_Draws = new System.Windows.Forms.TextBox();
            this.DrawScore = new System.Windows.Forms.Label();
            this.XWins = new System.Windows.Forms.Label();
            this.OWins = new System.Windows.Forms.Label();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_bottomLeft
            // 
            this.btn_bottomLeft.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_bottomLeft.Location = new System.Drawing.Point(12, 256);
            this.btn_bottomLeft.Name = "btn_bottomLeft";
            this.btn_bottomLeft.Size = new System.Drawing.Size(80, 80);
            this.btn_bottomLeft.TabIndex = 0;
            this.btn_bottomLeft.UseVisualStyleBackColor = true;
            this.btn_bottomLeft.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn_bottomCenter
            // 
            this.btn_bottomCenter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_bottomCenter.Location = new System.Drawing.Point(98, 256);
            this.btn_bottomCenter.Name = "btn_bottomCenter";
            this.btn_bottomCenter.Size = new System.Drawing.Size(80, 80);
            this.btn_bottomCenter.TabIndex = 1;
            this.btn_bottomCenter.UseVisualStyleBackColor = true;
            this.btn_bottomCenter.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn_bottomRight
            // 
            this.btn_bottomRight.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_bottomRight.Location = new System.Drawing.Point(184, 256);
            this.btn_bottomRight.Name = "btn_bottomRight";
            this.btn_bottomRight.Size = new System.Drawing.Size(80, 80);
            this.btn_bottomRight.TabIndex = 2;
            this.btn_bottomRight.UseVisualStyleBackColor = true;
            this.btn_bottomRight.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn_centerRight
            // 
            this.btn_centerRight.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_centerRight.Location = new System.Drawing.Point(184, 170);
            this.btn_centerRight.Name = "btn_centerRight";
            this.btn_centerRight.Size = new System.Drawing.Size(80, 80);
            this.btn_centerRight.TabIndex = 5;
            this.btn_centerRight.UseVisualStyleBackColor = true;
            this.btn_centerRight.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn_centerCenter
            // 
            this.btn_centerCenter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_centerCenter.Location = new System.Drawing.Point(98, 170);
            this.btn_centerCenter.Name = "btn_centerCenter";
            this.btn_centerCenter.Size = new System.Drawing.Size(80, 80);
            this.btn_centerCenter.TabIndex = 4;
            this.btn_centerCenter.UseVisualStyleBackColor = true;
            this.btn_centerCenter.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn_centerLeft
            // 
            this.btn_centerLeft.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_centerLeft.Location = new System.Drawing.Point(12, 170);
            this.btn_centerLeft.Name = "btn_centerLeft";
            this.btn_centerLeft.Size = new System.Drawing.Size(80, 80);
            this.btn_centerLeft.TabIndex = 3;
            this.btn_centerLeft.UseVisualStyleBackColor = true;
            this.btn_centerLeft.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn_topRight
            // 
            this.btn_topRight.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_topRight.Location = new System.Drawing.Point(184, 84);
            this.btn_topRight.Name = "btn_topRight";
            this.btn_topRight.Size = new System.Drawing.Size(80, 80);
            this.btn_topRight.TabIndex = 8;
            this.btn_topRight.UseVisualStyleBackColor = true;
            this.btn_topRight.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn_topCenter
            // 
            this.btn_topCenter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_topCenter.Location = new System.Drawing.Point(98, 84);
            this.btn_topCenter.Name = "btn_topCenter";
            this.btn_topCenter.Size = new System.Drawing.Size(80, 80);
            this.btn_topCenter.TabIndex = 7;
            this.btn_topCenter.UseVisualStyleBackColor = true;
            this.btn_topCenter.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn_topLeft
            // 
            this.btn_topLeft.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_topLeft.Location = new System.Drawing.Point(12, 84);
            this.btn_topLeft.Name = "btn_topLeft";
            this.btn_topLeft.Size = new System.Drawing.Size(80, 80);
            this.btn_topLeft.TabIndex = 6;
            this.btn_topLeft.UseVisualStyleBackColor = true;
            this.btn_topLeft.Click += new System.EventHandler(this.buttonClick);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Settings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripHelp});
            this.Settings.Location = new System.Drawing.Point(0, 0);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(278, 24);
            this.Settings.TabIndex = 9;
            this.Settings.Text = "Settings";
            this.Settings.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Settings_ItemClicked);
            // 
            // toolStripHelp
            // 
            this.toolStripHelp.Name = "toolStripHelp";
            this.toolStripHelp.Size = new System.Drawing.Size(44, 20);
            this.toolStripHelp.Text = "Help";
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.BackColor = System.Drawing.Color.Yellow;
            this.btn_NewGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_NewGame.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_NewGame.Location = new System.Drawing.Point(12, 342);
            this.btn_NewGame.Name = "btn_NewGame";
            this.btn_NewGame.Size = new System.Drawing.Size(80, 40);
            this.btn_NewGame.TabIndex = 10;
            this.btn_NewGame.Text = "New Game";
            this.btn_NewGame.UseVisualStyleBackColor = false;
            this.btn_NewGame.Click += new System.EventHandler(this.btn_NewGame_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.Lime;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Reset.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Reset.Location = new System.Drawing.Point(98, 341);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(80, 40);
            this.btn_Reset.TabIndex = 11;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Tomato;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Exit.Location = new System.Drawing.Point(184, 342);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(78, 40);
            this.btn_Exit.TabIndex = 13;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // textBox_Score
            // 
            this.textBox_Score.Location = new System.Drawing.Point(12, 40);
            this.textBox_Score.Name = "textBox_Score";
            this.textBox_Score.Size = new System.Drawing.Size(80, 23);
            this.textBox_Score.TabIndex = 14;
            this.textBox_Score.Text = "Your Score";
            this.textBox_Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Draws
            // 
            this.textBox_Draws.Location = new System.Drawing.Point(202, 30);
            this.textBox_Draws.Name = "textBox_Draws";
            this.textBox_Draws.Size = new System.Drawing.Size(44, 23);
            this.textBox_Draws.TabIndex = 15;
            this.textBox_Draws.Text = "Draws";
            this.textBox_Draws.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DrawScore
            // 
            this.DrawScore.AutoSize = true;
            this.DrawScore.Location = new System.Drawing.Point(215, 57);
            this.DrawScore.Name = "DrawScore";
            this.DrawScore.Size = new System.Drawing.Size(63, 15);
            this.DrawScore.TabIndex = 16;
            this.DrawScore.Text = "DrawScore";
            // 
            // XWins
            // 
            this.XWins.AutoSize = true;
            this.XWins.Location = new System.Drawing.Point(100, 30);
            this.XWins.Name = "XWins";
            this.XWins.Size = new System.Drawing.Size(40, 15);
            this.XWins.TabIndex = 17;
            this.XWins.Text = "XWins";
            // 
            // OWins
            // 
            this.OWins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OWins.AutoSize = true;
            this.OWins.Location = new System.Drawing.Point(98, 57);
            this.OWins.Name = "OWins";
            this.OWins.Size = new System.Drawing.Size(42, 15);
            this.OWins.TabIndex = 18;
            this.OWins.Text = "OWins";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(278, 393);
            this.Controls.Add(this.OWins);
            this.Controls.Add(this.XWins);
            this.Controls.Add(this.DrawScore);
            this.Controls.Add(this.textBox_Draws);
            this.Controls.Add(this.textBox_Score);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_NewGame);
            this.Controls.Add(this.btn_topRight);
            this.Controls.Add(this.btn_topCenter);
            this.Controls.Add(this.btn_topLeft);
            this.Controls.Add(this.btn_centerRight);
            this.Controls.Add(this.btn_centerCenter);
            this.Controls.Add(this.btn_centerLeft);
            this.Controls.Add(this.btn_bottomRight);
            this.Controls.Add(this.btn_bottomCenter);
            this.Controls.Add(this.btn_bottomLeft);
            this.Controls.Add(this.Settings);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_bottomLeft;
        private System.Windows.Forms.Button btn_bottomCenter;
        private System.Windows.Forms.Button btn_bottomRight;
        private System.Windows.Forms.Button btn_centerRight;
        private System.Windows.Forms.Button btn_centerCenter;
        private System.Windows.Forms.Button btn_centerLeft;
        private System.Windows.Forms.Button btn_topRight;
        private System.Windows.Forms.Button btn_topCenter;
        private System.Windows.Forms.Button btn_topLeft;
        private System.Windows.Forms.MenuStrip Settings;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripHelp;
        private System.Windows.Forms.Button btn_NewGame;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox textBox_Score;
        private System.Windows.Forms.TextBox textBox_Draws;
        private System.Windows.Forms.Label DrawScore;
        private System.Windows.Forms.Label XWins;
        private System.Windows.Forms.Label OWins;
    }
}

