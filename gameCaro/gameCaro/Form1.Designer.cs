namespace gameCaro
{
partial class Form1
{
/// <summary>
/// Required designer variable.
/// </summary>
private System.ComponentModel.IContainer components = null;
private System.Windows.Forms.Panel pnlChessBoard;
private System.Windows.Forms.Panel panelInfo;
private System.Windows.Forms.Panel panelChat;
private System.Windows.Forms.TextBox textbox_IP;
private System.Windows.Forms.Button BtnLAN;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.pictureBox_infoplayer = new System.Windows.Forms.PictureBox();
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChat = new System.Windows.Forms.Panel();
            this.rtbChatBox = new System.Windows.Forms.RichTextBox();
            this.progressBar_cooldown = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_playername = new System.Windows.Forms.TextBox();
            this.BtnLAN = new System.Windows.Forms.Button();
            this.textbox_IP = new System.Windows.Forms.TextBox();
            this.txtChatInput = new System.Windows.Forms.TextBox();
            this.btnSendChat = new System.Windows.Forms.Button();
            this.tmcooldown = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_infoplayer)).BeginInit();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChat.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_infoplayer
            // 
            this.pictureBox_infoplayer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox_infoplayer.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_infoplayer.Name = "pictureBox_infoplayer";
            this.pictureBox_infoplayer.Size = new System.Drawing.Size(187, 144);
            this.pictureBox_infoplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_infoplayer.TabIndex = 6;
            this.pictureBox_infoplayer.TabStop = false;
            this.pictureBox_infoplayer.Click += new System.EventHandler(this.pictureBox_infoplayer_Click);
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChessBoard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlChessBoard.BackColor = System.Drawing.Color.White;
            this.pnlChessBoard.Location = new System.Drawing.Point(0, 27);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(979, 654);
            this.pnlChessBoard.TabIndex = 0;
            this.pnlChessBoard.TabStop = true;
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.Controls.Add(this.pictureBox_infoplayer);
            this.panelInfo.Location = new System.Drawing.Point(32, 335);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(193, 150);
            this.panelInfo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::gameCaro.Properties.Resources.thi_dau_co_caro;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelChat
            // 
            this.panelChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelChat.Controls.Add(this.rtbChatBox);
            this.panelChat.Controls.Add(this.progressBar_cooldown);
            this.panelChat.Controls.Add(this.panel1);
            this.panelChat.Controls.Add(this.label1);
            this.panelChat.Controls.Add(this.textBox_playername);
            this.panelChat.Controls.Add(this.panelInfo);
            this.panelChat.Controls.Add(this.BtnLAN);
            this.panelChat.Controls.Add(this.textbox_IP);
            this.panelChat.Controls.Add(this.txtChatInput);
            this.panelChat.Controls.Add(this.btnSendChat);
            this.panelChat.Location = new System.Drawing.Point(976, 27);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(255, 657);
            this.panelChat.TabIndex = 2;
            this.panelChat.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChat_Paint);
            // 
            // rtbChatBox
            // 
            this.rtbChatBox.Location = new System.Drawing.Point(31, 491);
            this.rtbChatBox.Name = "rtbChatBox";
            this.rtbChatBox.Size = new System.Drawing.Size(194, 102);
            this.rtbChatBox.TabIndex = 13;
            this.rtbChatBox.Text = "";
            this.rtbChatBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // progressBar_cooldown
            // 
            this.progressBar_cooldown.Location = new System.Drawing.Point(31, 50);
            this.progressBar_cooldown.Name = "progressBar_cooldown";
            this.progressBar_cooldown.Size = new System.Drawing.Size(193, 24);
            this.progressBar_cooldown.TabIndex = 9;
            this.progressBar_cooldown.Click += new System.EventHandler(this.progressBar_cooldown_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(32, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 158);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "5 in a line to win";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_playername
            // 
            this.textBox_playername.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_playername.Location = new System.Drawing.Point(31, 80);
            this.textBox_playername.Name = "textBox_playername";
            this.textBox_playername.ReadOnly = true;
            this.textBox_playername.Size = new System.Drawing.Size(193, 22);
            this.textBox_playername.TabIndex = 8;
            this.textBox_playername.Text = "player name";
            this.textBox_playername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_playername.TextChanged += new System.EventHandler(this.textBox_playername_TextChanged);
            // 
            // BtnLAN
            // 
            this.BtnLAN.Location = new System.Drawing.Point(31, 136);
            this.BtnLAN.Name = "BtnLAN";
            this.BtnLAN.Size = new System.Drawing.Size(193, 29);
            this.BtnLAN.TabIndex = 4;
            this.BtnLAN.Text = "LAN Connect";
            this.BtnLAN.UseVisualStyleBackColor = true;
            this.BtnLAN.Click += new System.EventHandler(this.BtnLAN_Click);
            // 
            // textbox_IP
            // 
            this.textbox_IP.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_IP.Location = new System.Drawing.Point(31, 108);
            this.textbox_IP.Name = "textbox_IP";
            this.textbox_IP.Size = new System.Drawing.Size(193, 22);
            this.textbox_IP.TabIndex = 3;
            this.textbox_IP.Text = "IP";
            this.textbox_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_IP.TextChanged += new System.EventHandler(this.textbox_IP_TextChanged);
            // 
            // txtChatInput
            // 
            this.txtChatInput.Location = new System.Drawing.Point(31, 599);
            this.txtChatInput.Name = "txtChatInput";
            this.txtChatInput.Size = new System.Drawing.Size(138, 22);
            this.txtChatInput.TabIndex = 11;
            this.txtChatInput.TextChanged += new System.EventHandler(this.txtChatInput_TextChanged);
            // 
            // btnSendChat
            // 
            this.btnSendChat.Location = new System.Drawing.Point(178, 598);
            this.btnSendChat.Name = "btnSendChat";
            this.btnSendChat.Size = new System.Drawing.Size(47, 23);
            this.btnSendChat.TabIndex = 12;
            this.btnSendChat.Text = "Send";
            this.btnSendChat.UseVisualStyleBackColor = true;
            this.btnSendChat.Click += new System.EventHandler(this.btnSendChat_Click);
            // 
            // tmcooldown
            // 
            this.tmcooldown.Tick += new System.EventHandler(this.tmcooldown_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1231, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1231, 673);
            this.Controls.Add(this.panelChat);
            this.Controls.Add(this.pnlChessBoard);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Game Caro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_infoplayer)).EndInit();
            this.panelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChat.ResumeLayout(false);
            this.panelChat.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.TextBox textBox_playername;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ProgressBar progressBar_cooldown;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.PictureBox pictureBox_infoplayer;
    private System.Windows.Forms.Timer tmcooldown;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Button btnSendChat;
        private System.Windows.Forms.TextBox txtChatInput;
        private System.Windows.Forms.RichTextBox rtbChatBox;
    }
}