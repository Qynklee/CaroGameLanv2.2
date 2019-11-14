namespace CaroLAN_v2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Panel_ChessBoard = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xinThuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vánMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vềCaroGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vềDevTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.coolDownBar = new System.Windows.Forms.ProgressBar();
            this.GuestICON = new System.Windows.Forms.PictureBox();
            this.MainICON = new System.Windows.Forms.PictureBox();
            this.label_NameGuest = new System.Windows.Forms.Label();
            this.label_NameMain = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GuestICON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainICON)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_ChessBoard
            // 
            this.Panel_ChessBoard.BackColor = System.Drawing.SystemColors.Control;
            this.Panel_ChessBoard.Location = new System.Drawing.Point(9, 29);
            this.Panel_ChessBoard.Name = "Panel_ChessBoard";
            this.Panel_ChessBoard.Size = new System.Drawing.Size(850, 626);
            this.Panel_ChessBoard.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xinThuaToolStripMenuItem,
            this.vánMớiToolStripMenuItem,
            this.thoátGameToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // xinThuaToolStripMenuItem
            // 
            this.xinThuaToolStripMenuItem.Name = "xinThuaToolStripMenuItem";
            this.xinThuaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xinThuaToolStripMenuItem.Text = "Xin thua";
            // 
            // vánMớiToolStripMenuItem
            // 
            this.vánMớiToolStripMenuItem.Name = "vánMớiToolStripMenuItem";
            this.vánMớiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.vánMớiToolStripMenuItem.Text = "Ván mới";
            this.vánMớiToolStripMenuItem.Click += new System.EventHandler(this.vánMớiToolStripMenuItem_Click);
            // 
            // thoátGameToolStripMenuItem
            // 
            this.thoátGameToolStripMenuItem.Name = "thoátGameToolStripMenuItem";
            this.thoátGameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thoátGameToolStripMenuItem.Text = "Thoát Game";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vềCaroGameToolStripMenuItem,
            this.vềDevTeamToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // vềCaroGameToolStripMenuItem
            // 
            this.vềCaroGameToolStripMenuItem.Name = "vềCaroGameToolStripMenuItem";
            this.vềCaroGameToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.vềCaroGameToolStripMenuItem.Text = "Về Caro Game";
            // 
            // vềDevTeamToolStripMenuItem
            // 
            this.vềDevTeamToolStripMenuItem.Name = "vềDevTeamToolStripMenuItem";
            this.vềDevTeamToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.vềDevTeamToolStripMenuItem.Text = "Về DevTeam";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.coolDownBar);
            this.panel1.Controls.Add(this.GuestICON);
            this.panel1.Controls.Add(this.MainICON);
            this.panel1.Controls.Add(this.label_NameGuest);
            this.panel1.Controls.Add(this.label_NameMain);
            this.panel1.Location = new System.Drawing.Point(9, 661);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 95);
            this.panel1.TabIndex = 3;
            // 
            // coolDownBar
            // 
            this.coolDownBar.Location = new System.Drawing.Point(318, 38);
            this.coolDownBar.Maximum = 1000;
            this.coolDownBar.Name = "coolDownBar";
            this.coolDownBar.Size = new System.Drawing.Size(217, 23);
            this.coolDownBar.TabIndex = 7;
            // 
            // GuestICON
            // 
            this.GuestICON.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GuestICON.Location = new System.Drawing.Point(755, 0);
            this.GuestICON.Name = "GuestICON";
            this.GuestICON.Size = new System.Drawing.Size(95, 95);
            this.GuestICON.TabIndex = 6;
            this.GuestICON.TabStop = false;
            // 
            // MainICON
            // 
            this.MainICON.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainICON.Location = new System.Drawing.Point(0, 0);
            this.MainICON.Name = "MainICON";
            this.MainICON.Size = new System.Drawing.Size(95, 95);
            this.MainICON.TabIndex = 5;
            this.MainICON.TabStop = false;
            // 
            // label_NameGuest
            // 
            this.label_NameGuest.AutoSize = true;
            this.label_NameGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NameGuest.Location = new System.Drawing.Point(676, 38);
            this.label_NameGuest.Name = "label_NameGuest";
            this.label_NameGuest.Size = new System.Drawing.Size(53, 20);
            this.label_NameGuest.TabIndex = 4;
            this.label_NameGuest.Text = "label1";
            this.label_NameGuest.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_NameMain
            // 
            this.label_NameMain.AutoSize = true;
            this.label_NameMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NameMain.Location = new System.Drawing.Point(129, 38);
            this.label_NameMain.Name = "label_NameMain";
            this.label_NameMain.Size = new System.Drawing.Size(53, 20);
            this.label_NameMain.TabIndex = 3;
            this.label_NameMain.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 761);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel_ChessBoard);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Caro Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GuestICON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainICON)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Panel_ChessBoard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xinThuaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vánMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vềCaroGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vềDevTeamToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label_NameGuest;
        public System.Windows.Forms.Label label_NameMain;
        public System.Windows.Forms.PictureBox GuestICON;
        public System.Windows.Forms.PictureBox MainICON;
        private System.Windows.Forms.ProgressBar coolDownBar;
        private System.Windows.Forms.Timer timer1;
    }
}