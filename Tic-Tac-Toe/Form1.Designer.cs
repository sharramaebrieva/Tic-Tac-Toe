
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
            this.toolstripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu_Resume = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu_NewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu_ChoosePlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_bottomLeft
            // 
            this.btn_bottomLeft.Location = new System.Drawing.Point(12, 256);
            this.btn_bottomLeft.Name = "btn_bottomLeft";
            this.btn_bottomLeft.Size = new System.Drawing.Size(80, 80);
            this.btn_bottomLeft.TabIndex = 0;
            this.btn_bottomLeft.UseVisualStyleBackColor = true;
            this.btn_bottomLeft.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn_bottomCenter
            // 
            this.btn_bottomCenter.Location = new System.Drawing.Point(98, 256);
            this.btn_bottomCenter.Name = "btn_bottomCenter";
            this.btn_bottomCenter.Size = new System.Drawing.Size(80, 80);
            this.btn_bottomCenter.TabIndex = 1;
            this.btn_bottomCenter.UseVisualStyleBackColor = true;
            this.btn_bottomCenter.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn_bottomRight
            // 
            this.btn_bottomRight.Location = new System.Drawing.Point(184, 256);
            this.btn_bottomRight.Name = "btn_bottomRight";
            this.btn_bottomRight.Size = new System.Drawing.Size(80, 80);
            this.btn_bottomRight.TabIndex = 2;
            this.btn_bottomRight.UseVisualStyleBackColor = true;
            this.btn_bottomRight.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn_centerRight
            // 
            this.btn_centerRight.Location = new System.Drawing.Point(184, 170);
            this.btn_centerRight.Name = "btn_centerRight";
            this.btn_centerRight.Size = new System.Drawing.Size(80, 80);
            this.btn_centerRight.TabIndex = 5;
            this.btn_centerRight.UseVisualStyleBackColor = true;
            this.btn_centerRight.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn_centerCenter
            // 
            this.btn_centerCenter.Location = new System.Drawing.Point(98, 170);
            this.btn_centerCenter.Name = "btn_centerCenter";
            this.btn_centerCenter.Size = new System.Drawing.Size(80, 80);
            this.btn_centerCenter.TabIndex = 4;
            this.btn_centerCenter.UseVisualStyleBackColor = true;
            this.btn_centerCenter.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn_centerLeft
            // 
            this.btn_centerLeft.Location = new System.Drawing.Point(12, 170);
            this.btn_centerLeft.Name = "btn_centerLeft";
            this.btn_centerLeft.Size = new System.Drawing.Size(80, 80);
            this.btn_centerLeft.TabIndex = 3;
            this.btn_centerLeft.UseVisualStyleBackColor = true;
            this.btn_centerLeft.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn_topRight
            // 
            this.btn_topRight.Location = new System.Drawing.Point(184, 84);
            this.btn_topRight.Name = "btn_topRight";
            this.btn_topRight.Size = new System.Drawing.Size(80, 80);
            this.btn_topRight.TabIndex = 8;
            this.btn_topRight.UseVisualStyleBackColor = true;
            this.btn_topRight.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn_topCenter
            // 
            this.btn_topCenter.Location = new System.Drawing.Point(98, 84);
            this.btn_topCenter.Name = "btn_topCenter";
            this.btn_topCenter.Size = new System.Drawing.Size(80, 80);
            this.btn_topCenter.TabIndex = 7;
            this.btn_topCenter.UseVisualStyleBackColor = true;
            this.btn_topCenter.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn_topLeft
            // 
            this.btn_topLeft.Location = new System.Drawing.Point(12, 84);
            this.btn_topLeft.Name = "btn_topLeft";
            this.btn_topLeft.Size = new System.Drawing.Size(80, 80);
            this.btn_topLeft.TabIndex = 6;
            this.btn_topLeft.UseVisualStyleBackColor = true;
            this.btn_topLeft.Click += new System.EventHandler(this.buttonClick);
            // 
            // Settings
            // 
            this.Settings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripMenu,
            this.toolstripHelp});
            this.Settings.Location = new System.Drawing.Point(0, 0);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(278, 24);
            this.Settings.TabIndex = 9;
            this.Settings.Text = "Settings";
            this.Settings.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Settings_ItemClicked);
            // 
            // toolstripMenu
            // 
            this.toolstripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenu_Resume,
            this.toolStripMenu_NewGame,
            this.toolStripMenu_ChoosePlayer,
            this.toolStripMenu_Exit});
            this.toolstripMenu.Name = "toolstripMenu";
            this.toolstripMenu.Size = new System.Drawing.Size(50, 20);
            this.toolstripMenu.Text = "Menu";
            // 
            // toolStripMenu_Resume
            // 
            this.toolStripMenu_Resume.Name = "toolStripMenu_Resume";
            this.toolStripMenu_Resume.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenu_Resume.Text = "Resume";
            // 
            // toolStripMenu_NewGame
            // 
            this.toolStripMenu_NewGame.Name = "toolStripMenu_NewGame";
            this.toolStripMenu_NewGame.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenu_NewGame.Text = "New Game";
            // 
            // toolStripMenu_ChoosePlayer
            // 
            this.toolStripMenu_ChoosePlayer.Name = "toolStripMenu_ChoosePlayer";
            this.toolStripMenu_ChoosePlayer.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenu_ChoosePlayer.Text = "Choose Player";
            // 
            // toolStripMenu_Exit
            // 
            this.toolStripMenu_Exit.Name = "toolStripMenu_Exit";
            this.toolStripMenu_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.toolStripMenu_Exit.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenu_Exit.Text = "Exit";
            // 
            // toolstripHelp
            // 
            this.toolstripHelp.Name = "toolstripHelp";
            this.toolstripHelp.Size = new System.Drawing.Size(44, 20);
            this.toolstripHelp.Text = "Help";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 348);
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
        private System.Windows.Forms.ToolStripMenuItem toolstripMenu;
        private System.Windows.Forms.ToolStripMenuItem toolstripHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu_NewGame;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu_Resume;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu_ChoosePlayer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu_Exit;
    }
}

