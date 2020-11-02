namespace ServiceAnother
{
    partial class Home
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelForButtons = new System.Windows.Forms.Panel();
            this.infoButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.serviceButton = new System.Windows.Forms.Button();
            this.clientsButton = new System.Windows.Forms.Button();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.userNamelabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.userPB = new System.Windows.Forms.PictureBox();
            this.panelForButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPB)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForButtons
            // 
            this.panelForButtons.Controls.Add(this.infoButton);
            this.panelForButtons.Controls.Add(this.usersButton);
            this.panelForButtons.Controls.Add(this.serviceButton);
            this.panelForButtons.Controls.Add(this.clientsButton);
            this.panelForButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelForButtons.Location = new System.Drawing.Point(247, 0);
            this.panelForButtons.Name = "panelForButtons";
            this.panelForButtons.Size = new System.Drawing.Size(130, 524);
            this.panelForButtons.TabIndex = 5;
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.infoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoButton.FlatAppearance.BorderSize = 0;
            this.infoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(18)))), ((int)(((byte)(89)))));
            this.infoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(109)))), ((int)(((byte)(196)))));
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoButton.Font = new System.Drawing.Font("Meiryo", 10F, System.Drawing.FontStyle.Bold);
            this.infoButton.ForeColor = System.Drawing.Color.White;
            this.infoButton.Image = global::ServiceAnother.Properties.Resources.info64;
            this.infoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.infoButton.Location = new System.Drawing.Point(0, 390);
            this.infoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.infoButton.Name = "infoButton";
            this.infoButton.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.infoButton.Size = new System.Drawing.Size(130, 130);
            this.infoButton.TabIndex = 8;
            this.infoButton.Text = "Справка";
            this.infoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.infoButton.UseVisualStyleBackColor = false;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.usersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersButton.FlatAppearance.BorderSize = 0;
            this.usersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(18)))), ((int)(((byte)(89)))));
            this.usersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(109)))), ((int)(((byte)(196)))));
            this.usersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersButton.Font = new System.Drawing.Font("Meiryo", 10F, System.Drawing.FontStyle.Bold);
            this.usersButton.ForeColor = System.Drawing.Color.White;
            this.usersButton.Image = global::ServiceAnother.Properties.Resources.users;
            this.usersButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.usersButton.Location = new System.Drawing.Point(0, 260);
            this.usersButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usersButton.Name = "usersButton";
            this.usersButton.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.usersButton.Size = new System.Drawing.Size(130, 130);
            this.usersButton.TabIndex = 6;
            this.usersButton.Text = "Пользователи";
            this.usersButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.usersButton.UseVisualStyleBackColor = false;
            this.usersButton.Visible = false;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // serviceButton
            // 
            this.serviceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.serviceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.serviceButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.serviceButton.FlatAppearance.BorderSize = 0;
            this.serviceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(18)))), ((int)(((byte)(89)))));
            this.serviceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(109)))), ((int)(((byte)(196)))));
            this.serviceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serviceButton.Font = new System.Drawing.Font("Meiryo", 10F, System.Drawing.FontStyle.Bold);
            this.serviceButton.ForeColor = System.Drawing.Color.White;
            this.serviceButton.Image = global::ServiceAnother.Properties.Resources.service60;
            this.serviceButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.serviceButton.Location = new System.Drawing.Point(0, 130);
            this.serviceButton.Margin = new System.Windows.Forms.Padding(4);
            this.serviceButton.Name = "serviceButton";
            this.serviceButton.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.serviceButton.Size = new System.Drawing.Size(130, 130);
            this.serviceButton.TabIndex = 5;
            this.serviceButton.Text = "Услуги";
            this.serviceButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.serviceButton.UseVisualStyleBackColor = false;
            this.serviceButton.Click += new System.EventHandler(this.serviceButton_Click);
            // 
            // clientsButton
            // 
            this.clientsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.clientsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientsButton.FlatAppearance.BorderSize = 0;
            this.clientsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(18)))), ((int)(((byte)(89)))));
            this.clientsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(109)))), ((int)(((byte)(196)))));
            this.clientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsButton.Font = new System.Drawing.Font("Meiryo", 10F, System.Drawing.FontStyle.Bold);
            this.clientsButton.ForeColor = System.Drawing.Color.White;
            this.clientsButton.Image = global::ServiceAnother.Properties.Resources.clients;
            this.clientsButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clientsButton.Location = new System.Drawing.Point(0, 0);
            this.clientsButton.Margin = new System.Windows.Forms.Padding(4);
            this.clientsButton.Name = "clientsButton";
            this.clientsButton.Size = new System.Drawing.Size(130, 130);
            this.clientsButton.TabIndex = 1;
            this.clientsButton.Text = "Клиенты";
            this.clientsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.clientsButton.UseVisualStyleBackColor = false;
            this.clientsButton.Click += new System.EventHandler(this.clientsButton_Click);
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Meiryo", 10F, System.Drawing.FontStyle.Bold);
            this.fullNameLabel.ForeColor = System.Drawing.Color.White;
            this.fullNameLabel.Location = new System.Drawing.Point(23, 273);
            this.fullNameLabel.MaximumSize = new System.Drawing.Size(210, 0);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(80, 21);
            this.fullNameLabel.TabIndex = 8;
            this.fullNameLabel.Text = "FullName";
            // 
            // userNamelabel
            // 
            this.userNamelabel.AutoSize = true;
            this.userNamelabel.Font = new System.Drawing.Font("Meiryo", 10F, System.Drawing.FontStyle.Bold);
            this.userNamelabel.ForeColor = System.Drawing.Color.White;
            this.userNamelabel.Location = new System.Drawing.Point(23, 252);
            this.userNamelabel.Name = "userNamelabel";
            this.userNamelabel.Size = new System.Drawing.Size(88, 21);
            this.userNamelabel.TabIndex = 10;
            this.userNamelabel.Text = "UserName";
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(18)))), ((int)(((byte)(89)))));
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(109)))), ((int)(((byte)(196)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Meiryo", 10F, System.Drawing.FontStyle.Bold);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Image = global::ServiceAnother.Properties.Resources.changeUser32;
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(2, 488);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(239, 32);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Сменить пользователя";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // userPB
            // 
            this.userPB.Location = new System.Drawing.Point(27, 49);
            this.userPB.Name = "userPB";
            this.userPB.Size = new System.Drawing.Size(200, 200);
            this.userPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPB.TabIndex = 7;
            this.userPB.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.CancelButton = this.backButton;
            this.ClientSize = new System.Drawing.Size(377, 524);
            this.Controls.Add(this.userNamelabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.userPB);
            this.Controls.Add(this.panelForButtons);
            this.Controls.Add(this.backButton);
            this.Font = new System.Drawing.Font("Meiryo", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelForButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel panelForButtons;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button serviceButton;
        private System.Windows.Forms.Button clientsButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.PictureBox userPB;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label userNamelabel;
    }
}

