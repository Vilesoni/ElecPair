namespace ServiceAnother
{
    partial class SendForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendForm));
            this.toolPanel = new System.Windows.Forms.Panel();
            this.printButton = new System.Windows.Forms.Button();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mailTypeUD = new System.Windows.Forms.DomainUpDown();
            this.mailTB = new System.Windows.Forms.TextBox();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.mailButton = new System.Windows.Forms.Button();
            this.fileButton = new System.Windows.Forms.Button();
            this.moveToolsPanelPB = new System.Windows.Forms.PictureBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusText = new System.Windows.Forms.ToolStripLabel();
            this.infoTB = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolPanel.SuspendLayout();
            this.inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveToolsPanelPB)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolPanel
            // 
            this.toolPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.toolPanel.Controls.Add(this.printButton);
            this.toolPanel.Controls.Add(this.inputPanel);
            this.toolPanel.Controls.Add(this.mailButton);
            this.toolPanel.Controls.Add(this.fileButton);
            this.toolPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolPanel.Location = new System.Drawing.Point(0, 0);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(200, 450);
            this.toolPanel.TabIndex = 0;
            this.toolPanel.Visible = false;
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.printButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.printButton.FlatAppearance.BorderSize = 0;
            this.printButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(18)))), ((int)(((byte)(89)))));
            this.printButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(109)))), ((int)(((byte)(196)))));
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Meiryo", 10F, System.Drawing.FontStyle.Bold);
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printButton.Location = new System.Drawing.Point(0, 176);
            this.printButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(200, 40);
            this.printButton.TabIndex = 9;
            this.printButton.Text = "Печать";
            this.printButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            this.printButton.Enter += new System.EventHandler(this.FocusEntered);
            // 
            // inputPanel
            // 
            this.inputPanel.Controls.Add(this.label1);
            this.inputPanel.Controls.Add(this.mailTypeUD);
            this.inputPanel.Controls.Add(this.mailTB);
            this.inputPanel.Controls.Add(this.minusButton);
            this.inputPanel.Controls.Add(this.plusButton);
            this.inputPanel.Controls.Add(this.saveButton);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputPanel.Location = new System.Drawing.Point(0, 80);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(200, 96);
            this.inputPanel.TabIndex = 8;
            this.inputPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Имя аккаунта";
            // 
            // mailTypeUD
            // 
            this.mailTypeUD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mailTypeUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mailTypeUD.Items.Add("@mail.ru");
            this.mailTypeUD.Items.Add("@gmail.com");
            this.mailTypeUD.Location = new System.Drawing.Point(122, 23);
            this.mailTypeUD.Name = "mailTypeUD";
            this.mailTypeUD.ReadOnly = true;
            this.mailTypeUD.Size = new System.Drawing.Size(78, 25);
            this.mailTypeUD.TabIndex = 26;
            this.mailTypeUD.Text = "@mail.ru";
            this.mailTypeUD.Wrap = true;
            this.mailTypeUD.Enter += new System.EventHandler(this.FocusEntered);
            // 
            // mailTB
            // 
            this.mailTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mailTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mailTB.Location = new System.Drawing.Point(-1, 23);
            this.mailTB.Name = "mailTB";
            this.mailTB.Size = new System.Drawing.Size(122, 25);
            this.mailTB.TabIndex = 25;
            this.mailTB.Enter += new System.EventHandler(this.FocusEntered);
            // 
            // minusButton
            // 
            this.minusButton.Image = global::ServiceAnother.Properties.Resources.cross15;
            this.minusButton.Location = new System.Drawing.Point(26, 391);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(20, 20);
            this.minusButton.TabIndex = 24;
            this.minusButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.minusButton.UseVisualStyleBackColor = true;
            // 
            // plusButton
            // 
            this.plusButton.Image = global::ServiceAnother.Properties.Resources.plus15;
            this.plusButton.Location = new System.Drawing.Point(0, 391);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(20, 20);
            this.plusButton.TabIndex = 22;
            this.plusButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.plusButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(18)))), ((int)(((byte)(89)))));
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(109)))), ((int)(((byte)(196)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Meiryo", 10F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Image = global::ServiceAnother.Properties.Resources.finish32;
            this.saveButton.Location = new System.Drawing.Point(0, 64);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(200, 32);
            this.saveButton.TabIndex = 21;
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.saveButton, "Применить");
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            this.saveButton.Enter += new System.EventHandler(this.FocusEntered);
            // 
            // mailButton
            // 
            this.mailButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.mailButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.mailButton.FlatAppearance.BorderSize = 0;
            this.mailButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(18)))), ((int)(((byte)(89)))));
            this.mailButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(109)))), ((int)(((byte)(196)))));
            this.mailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mailButton.Font = new System.Drawing.Font("Meiryo", 10F, System.Drawing.FontStyle.Bold);
            this.mailButton.ForeColor = System.Drawing.Color.White;
            this.mailButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mailButton.Location = new System.Drawing.Point(0, 40);
            this.mailButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mailButton.Name = "mailButton";
            this.mailButton.Size = new System.Drawing.Size(200, 40);
            this.mailButton.TabIndex = 6;
            this.mailButton.Text = "Почта";
            this.mailButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mailButton.UseVisualStyleBackColor = false;
            this.mailButton.Click += new System.EventHandler(this.mailButton_Click);
            this.mailButton.Enter += new System.EventHandler(this.FocusEntered);
            // 
            // fileButton
            // 
            this.fileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.fileButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.fileButton.FlatAppearance.BorderSize = 0;
            this.fileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(18)))), ((int)(((byte)(89)))));
            this.fileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(109)))), ((int)(((byte)(196)))));
            this.fileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileButton.Font = new System.Drawing.Font("Meiryo", 10F, System.Drawing.FontStyle.Bold);
            this.fileButton.ForeColor = System.Drawing.Color.White;
            this.fileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fileButton.Location = new System.Drawing.Point(0, 0);
            this.fileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(200, 40);
            this.fileButton.TabIndex = 5;
            this.fileButton.Text = "Файл";
            this.fileButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fileButton.UseVisualStyleBackColor = false;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            this.fileButton.Enter += new System.EventHandler(this.FocusEntered);
            // 
            // moveToolsPanelPB
            // 
            this.moveToolsPanelPB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.moveToolsPanelPB.Dock = System.Windows.Forms.DockStyle.Left;
            this.moveToolsPanelPB.Image = global::ServiceAnother.Properties.Resources.menu32;
            this.moveToolsPanelPB.Location = new System.Drawing.Point(200, 0);
            this.moveToolsPanelPB.Name = "moveToolsPanelPB";
            this.moveToolsPanelPB.Size = new System.Drawing.Size(32, 450);
            this.moveToolsPanelPB.TabIndex = 3;
            this.moveToolsPanelPB.TabStop = false;
            this.moveToolsPanelPB.Click += new System.EventHandler(this.moveToolsPanelPB_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Title = "Сохранить файл как";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText});
            this.toolStrip1.Location = new System.Drawing.Point(232, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(546, 25);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Enter += new System.EventHandler(this.FocusEntered);
            // 
            // statusText
            // 
            this.statusText.Font = new System.Drawing.Font("Meiryo", 9F);
            this.statusText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(0, 22);
            // 
            // infoTB
            // 
            this.infoTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.infoTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoTB.Font = new System.Drawing.Font("Meiryo", 10F, System.Drawing.FontStyle.Italic);
            this.infoTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.infoTB.Location = new System.Drawing.Point(232, 25);
            this.infoTB.Multiline = true;
            this.infoTB.Name = "infoTB";
            this.infoTB.ReadOnly = true;
            this.infoTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoTB.Size = new System.Drawing.Size(546, 425);
            this.infoTB.TabIndex = 24;
            this.infoTB.WordWrap = false;
            this.infoTB.Enter += new System.EventHandler(this.FocusEntered);
            // 
            // SendForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(778, 450);
            this.Controls.Add(this.infoTB);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.moveToolsPanelPB);
            this.Controls.Add(this.toolPanel);
            this.Font = new System.Drawing.Font("Meiryo", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SendForm";
            this.Text = "Отправить";
            this.Load += new System.EventHandler(this.SendForm_Load);
            this.toolPanel.ResumeLayout(false);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveToolsPanelPB)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.Button mailButton;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.PictureBox moveToolsPanelPB;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DomainUpDown mailTypeUD;
        private System.Windows.Forms.TextBox mailTB;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel statusText;
        private System.Windows.Forms.TextBox infoTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip;
    }
}