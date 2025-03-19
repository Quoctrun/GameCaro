namespace gameCaro
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelChessBoard;
        private System.Windows.Forms.Panel panel_image_show;

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
            this.panelChessBoard = new System.Windows.Forms.Panel();
            this.panel_image_show = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.textbutton_IP = new System.Windows.Forms.TextBox();
            this.Button_connectLAN = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.progressBar_cooldown = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_player_name = new System.Windows.Forms.TextBox();
            this.panelChat = new System.Windows.Forms.Panel();
            this.panel_image_show.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChessBoard
            // 
            this.panelChessBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChessBoard.BackColor = System.Drawing.Color.White;
            this.panelChessBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelChessBoard.Location = new System.Drawing.Point(12, 12);
            this.panelChessBoard.Name = "panelChessBoard";
            this.panelChessBoard.Size = new System.Drawing.Size(733, 724);
            this.panelChessBoard.TabIndex = 0;
            // 
            // panel_image_show
            // 
            this.panel_image_show.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_image_show.Controls.Add(this.pictureBox1);
            this.panel_image_show.Location = new System.Drawing.Point(751, 12);
            this.panel_image_show.Name = "panel_image_show";
            this.panel_image_show.Size = new System.Drawing.Size(345, 223);
            this.panel_image_show.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::gameCaro.Properties.Resources.thi_dau_co_caro;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(19, 253);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(310, 30);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset Game";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // textbutton_IP
            // 
            this.textbutton_IP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textbutton_IP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbutton_IP.Location = new System.Drawing.Point(19, 176);
            this.textbutton_IP.Name = "textbutton_IP";
            this.textbutton_IP.Size = new System.Drawing.Size(310, 34);
            this.textbutton_IP.TabIndex = 3;
            this.textbutton_IP.Text = "IP";
            this.textbutton_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Button_connectLAN
            // 
            this.Button_connectLAN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_connectLAN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_connectLAN.Location = new System.Drawing.Point(19, 216);
            this.Button_connectLAN.Name = "Button_connectLAN";
            this.Button_connectLAN.Size = new System.Drawing.Size(310, 31);
            this.Button_connectLAN.TabIndex = 4;
            this.Button_connectLAN.Text = "LAN Connect";
            this.Button_connectLAN.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(19, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 103);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // progressBar_cooldown
            // 
            this.progressBar_cooldown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar_cooldown.Location = new System.Drawing.Point(182, 93);
            this.progressBar_cooldown.Name = "progressBar_cooldown";
            this.progressBar_cooldown.Size = new System.Drawing.Size(138, 37);
            this.progressBar_cooldown.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "5 in a line to win !";
            // 
            // textBox_player_name
            // 
            this.textBox_player_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_player_name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_player_name.Location = new System.Drawing.Point(21, 136);
            this.textBox_player_name.Name = "textBox_player_name";
            this.textBox_player_name.ReadOnly = true;
            this.textBox_player_name.Size = new System.Drawing.Size(308, 34);
            this.textBox_player_name.TabIndex = 10;
            this.textBox_player_name.Text = "Player Name";
            this.textBox_player_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelChat
            // 
            this.panelChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelChat.Controls.Add(this.textBox_player_name);
            this.panelChat.Controls.Add(this.label1);
            this.panelChat.Controls.Add(this.progressBar_cooldown);
            this.panelChat.Controls.Add(this.pictureBox2);
            this.panelChat.Controls.Add(this.Button_connectLAN);
            this.panelChat.Controls.Add(this.textbutton_IP);
            this.panelChat.Controls.Add(this.btnReset);
            this.panelChat.Location = new System.Drawing.Point(754, 241);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(342, 495);
            this.panelChat.TabIndex = 2;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1108, 748);
            this.Controls.Add(this.panelChessBoard);
            this.Controls.Add(this.panel_image_show);
            this.Controls.Add(this.panelChat);
            this.Name = "Form1";
            this.Text = "Game Caro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_image_show.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelChat.ResumeLayout(false);
            this.panelChat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox textbutton_IP;
        private System.Windows.Forms.Button Button_connectLAN;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar progressBar_cooldown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_player_name;
        private System.Windows.Forms.Panel panelChat;
    }
}
