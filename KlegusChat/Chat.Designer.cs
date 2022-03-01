namespace KlegusChat
{
    partial class Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.leftP = new Bunifu.UI.WinForms.BunifuPanel();
            this.ChatTOP = new Bunifu.UI.WinForms.BunifuLabel();
            this.MSG = new System.Windows.Forms.FlowLayoutPanel();
            this.UserStatus = new System.Windows.Forms.Panel();
            this.statusDB = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.statusUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.UserStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KlegusChat.Properties.Resources.minimize;
            this.pictureBox2.Location = new System.Drawing.Point(735, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KlegusChat.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(769, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // leftP
            // 
            this.leftP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.leftP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftP.BackgroundImage")));
            this.leftP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftP.BorderColor = System.Drawing.Color.Transparent;
            this.leftP.BorderRadius = 3;
            this.leftP.BorderThickness = 1;
            this.leftP.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftP.Location = new System.Drawing.Point(0, 25);
            this.leftP.Name = "leftP";
            this.leftP.ShowBorders = true;
            this.leftP.Size = new System.Drawing.Size(200, 425);
            this.leftP.TabIndex = 0;
            // 
            // ChatTOP
            // 
            this.ChatTOP.AllowParentOverrides = false;
            this.ChatTOP.AutoEllipsis = false;
            this.ChatTOP.CursorType = System.Windows.Forms.Cursors.Default;
            this.ChatTOP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ChatTOP.ForeColor = System.Drawing.Color.White;
            this.ChatTOP.Location = new System.Drawing.Point(4, 6);
            this.ChatTOP.Name = "ChatTOP";
            this.ChatTOP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChatTOP.Size = new System.Drawing.Size(0, 0);
            this.ChatTOP.TabIndex = 4;
            this.ChatTOP.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.ChatTOP.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // MSG
            // 
            this.MSG.AutoScroll = true;
            this.MSG.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MSG.Location = new System.Drawing.Point(200, 55);
            this.MSG.Name = "MSG";
            this.MSG.Size = new System.Drawing.Size(600, 395);
            this.MSG.TabIndex = 5;
            this.MSG.WrapContents = false;
            // 
            // UserStatus
            // 
            this.UserStatus.Controls.Add(this.statusUser);
            this.UserStatus.Controls.Add(this.user);
            this.UserStatus.Location = new System.Drawing.Point(200, 25);
            this.UserStatus.Margin = new System.Windows.Forms.Padding(0);
            this.UserStatus.Name = "UserStatus";
            this.UserStatus.Size = new System.Drawing.Size(600, 27);
            this.UserStatus.TabIndex = 0;
            // 
            // statusDB
            // 
            this.statusDB.AutoSize = true;
            this.statusDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusDB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusDB.ForeColor = System.Drawing.Color.Lime;
            this.statusDB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.statusDB.Location = new System.Drawing.Point(683, 6);
            this.statusDB.Name = "statusDB";
            this.statusDB.Size = new System.Drawing.Size(0, 15);
            this.statusDB.TabIndex = 6;
            // 
            // user
            // 
            this.user.Dock = System.Windows.Forms.DockStyle.Left;
            this.user.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.user.ForeColor = System.Drawing.Color.White;
            this.user.Location = new System.Drawing.Point(0, 0);
            this.user.Margin = new System.Windows.Forms.Padding(0);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(100, 27);
            this.user.TabIndex = 0;
            this.user.Click += new System.EventHandler(this.label1_Click);
            // 
            // statusUser
            // 
            this.statusUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.statusUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusUser.ForeColor = System.Drawing.Color.White;
            this.statusUser.Location = new System.Drawing.Point(100, 0);
            this.statusUser.Margin = new System.Windows.Forms.Padding(0);
            this.statusUser.Name = "statusUser";
            this.statusUser.Size = new System.Drawing.Size(100, 27);
            this.statusUser.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(200, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 425);
            this.panel1.TabIndex = 1;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusDB);
            this.Controls.Add(this.MSG);
            this.Controls.Add(this.leftP);
            this.Controls.Add(this.UserStatus);
            this.Controls.Add(this.ChatTOP);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Chat";
            this.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Chat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.UserStatus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel leftP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.UI.WinForms.BunifuLabel ChatTOP;
        private System.Windows.Forms.FlowLayoutPanel MSG;
        private System.Windows.Forms.Panel UserStatus;
        private System.Windows.Forms.Label statusDB;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label statusUser;
        private System.Windows.Forms.Panel panel1;
    }
}