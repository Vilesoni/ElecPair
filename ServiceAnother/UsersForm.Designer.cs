namespace ServiceAnother
{
    partial class UsersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.usersTable = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HiddenPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IfAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.recordsAmount = new System.Windows.Forms.ToolStripLabel();
            this.recordsValue = new System.Windows.Forms.ToolStripLabel();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectedRecords = new System.Windows.Forms.ToolStripLabel();
            this.valueSelectedRecords = new System.Windows.Forms.ToolStripLabel();
            this.Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllButton = new System.Windows.Forms.ToolStripButton();
            this.Separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.clearSelection = new System.Windows.Forms.ToolStripButton();
            this.Separator4 = new System.Windows.Forms.ToolStripSeparator();
            this.statusText = new System.Windows.Forms.ToolStripLabel();
            this.moveToolsPanelPB = new System.Windows.Forms.PictureBox();
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.adminRights = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fullNameTB = new System.Windows.Forms.TextBox();
            this.passwTB = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.extSearchbutton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveToolsPanelPB)).BeginInit();
            this.toolsPanel.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // usersTable
            // 
            this.usersTable.AllowUserToAddRows = false;
            this.usersTable.AllowUserToDeleteRows = false;
            this.usersTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(185)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usersTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.usersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.usersTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.usersTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Meiryo", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.usersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.UserName,
            this.Password,
            this.HiddenPassword,
            this.FullName,
            this.IfAdmin,
            this.CheckBox});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Meiryo", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(170)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.usersTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersTable.EnableHeadersVisualStyles = false;
            this.usersTable.Location = new System.Drawing.Point(233, 25);
            this.usersTable.MultiSelect = false;
            this.usersTable.Name = "usersTable";
            this.usersTable.ReadOnly = true;
            this.usersTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.usersTable.RowHeadersVisible = false;
            this.usersTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersTable.Size = new System.Drawing.Size(583, 425);
            this.usersTable.TabIndex = 23;
            this.usersTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersTable_CellClick);
            this.usersTable.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.usersTable_CellFormatting);
            this.usersTable.Enter += new System.EventHandler(this.FocusEntered);
            // 
            // num
            // 
            this.num.HeaderText = "ID";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Visible = false;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName.FillWeight = 107.3246F;
            this.UserName.HeaderText = "Логин";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.FillWeight = 107.3246F;
            this.Password.HeaderText = "Пароль";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HiddenPassword
            // 
            this.HiddenPassword.HeaderText = "HiddenPassword";
            this.HiddenPassword.Name = "HiddenPassword";
            this.HiddenPassword.ReadOnly = true;
            this.HiddenPassword.Visible = false;
            // 
            // FullName
            // 
            this.FullName.FillWeight = 107.8722F;
            this.FullName.HeaderText = "ФИО";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // IfAdmin
            // 
            this.IfAdmin.FillWeight = 107.8722F;
            this.IfAdmin.HeaderText = "Права администратора";
            this.IfAdmin.Name = "IfAdmin";
            this.IfAdmin.ReadOnly = true;
            this.IfAdmin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CheckBox
            // 
            this.CheckBox.FillWeight = 60.7591F;
            this.CheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBox.HeaderText = "";
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordsAmount,
            this.recordsValue,
            this.Separator1,
            this.selectedRecords,
            this.valueSelectedRecords,
            this.Separator2,
            this.selectAllButton,
            this.Separator3,
            this.clearSelection,
            this.Separator4,
            this.statusText});
            this.toolStrip1.Location = new System.Drawing.Point(233, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(583, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Enter += new System.EventHandler(this.FocusEntered);
            // 
            // recordsAmount
            // 
            this.recordsAmount.Font = new System.Drawing.Font("Meiryo", 9F);
            this.recordsAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.recordsAmount.Name = "recordsAmount";
            this.recordsAmount.Size = new System.Drawing.Size(95, 22);
            this.recordsAmount.Text = "Всего записей";
            // 
            // recordsValue
            // 
            this.recordsValue.Font = new System.Drawing.Font("Meiryo", 9F);
            this.recordsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.recordsValue.Name = "recordsValue";
            this.recordsValue.Size = new System.Drawing.Size(39, 22);
            this.recordsValue.Text = "value";
            // 
            // Separator1
            // 
            this.Separator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(6, 25);
            // 
            // selectedRecords
            // 
            this.selectedRecords.Font = new System.Drawing.Font("Meiryo", 9F);
            this.selectedRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectedRecords.Name = "selectedRecords";
            this.selectedRecords.Size = new System.Drawing.Size(113, 22);
            this.selectedRecords.Text = "Выбрано записей";
            // 
            // valueSelectedRecords
            // 
            this.valueSelectedRecords.Font = new System.Drawing.Font("Meiryo", 9F);
            this.valueSelectedRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.valueSelectedRecords.Name = "valueSelectedRecords";
            this.valueSelectedRecords.Size = new System.Drawing.Size(39, 22);
            this.valueSelectedRecords.Text = "value";
            // 
            // Separator2
            // 
            this.Separator2.Name = "Separator2";
            this.Separator2.Size = new System.Drawing.Size(6, 25);
            // 
            // selectAllButton
            // 
            this.selectAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectAllButton.Image = global::ServiceAnother.Properties.Resources.selectAll23;
            this.selectAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(23, 22);
            this.selectAllButton.Text = "Выбрать все";
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // Separator3
            // 
            this.Separator3.Name = "Separator3";
            this.Separator3.Size = new System.Drawing.Size(6, 25);
            // 
            // clearSelection
            // 
            this.clearSelection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearSelection.Font = new System.Drawing.Font("Meiryo", 9F);
            this.clearSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearSelection.Image = global::ServiceAnother.Properties.Resources.clearSelect23;
            this.clearSelection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearSelection.Name = "clearSelection";
            this.clearSelection.Size = new System.Drawing.Size(23, 22);
            this.clearSelection.Text = "Убрать выделение";
            this.clearSelection.Click += new System.EventHandler(this.clearSelection_Click);
            // 
            // Separator4
            // 
            this.Separator4.Name = "Separator4";
            this.Separator4.Size = new System.Drawing.Size(6, 25);
            // 
            // statusText
            // 
            this.statusText.Font = new System.Drawing.Font("Meiryo", 9F);
            this.statusText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(0, 22);
            // 
            // moveToolsPanelPB
            // 
            this.moveToolsPanelPB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.moveToolsPanelPB.Dock = System.Windows.Forms.DockStyle.Left;
            this.moveToolsPanelPB.ErrorImage = null;
            this.moveToolsPanelPB.Image = global::ServiceAnother.Properties.Resources.menu32;
            this.moveToolsPanelPB.Location = new System.Drawing.Point(201, 0);
            this.moveToolsPanelPB.Name = "moveToolsPanelPB";
            this.moveToolsPanelPB.Size = new System.Drawing.Size(32, 450);
            this.moveToolsPanelPB.TabIndex = 21;
            this.moveToolsPanelPB.TabStop = false;
            this.moveToolsPanelPB.Click += new System.EventHandler(this.moveToolsPanelPB_Click);
            // 
            // toolsPanel
            // 
            this.toolsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.toolsPanel.Controls.Add(this.inputPanel);
            this.toolsPanel.Controls.Add(this.extSearchbutton);
            this.toolsPanel.Controls.Add(this.backButton);
            this.toolsPanel.Controls.Add(this.delButton);
            this.toolsPanel.Controls.Add(this.editButton);
            this.toolsPanel.Controls.Add(this.addButton);
            this.toolsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolsPanel.Location = new System.Drawing.Point(0, 0);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(201, 450);
            this.toolsPanel.TabIndex = 20;
            this.toolsPanel.Visible = false;
            // 
            // inputPanel
            // 
            this.inputPanel.Controls.Add(this.adminRights);
            this.inputPanel.Controls.Add(this.label4);
            this.inputPanel.Controls.Add(this.fullNameTB);
            this.inputPanel.Controls.Add(this.passwTB);
            this.inputPanel.Controls.Add(this.saveButton);
            this.inputPanel.Controls.Add(this.label3);
            this.inputPanel.Controls.Add(this.loginTB);
            this.inputPanel.Controls.Add(this.label2);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputPanel.Location = new System.Drawing.Point(0, 160);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(201, 224);
            this.inputPanel.TabIndex = 25;
            this.inputPanel.Visible = false;
            // 
            // adminRights
            // 
            this.adminRights.AutoSize = true;
            this.adminRights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminRights.Font = new System.Drawing.Font("Meiryo", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminRights.ForeColor = System.Drawing.Color.White;
            this.adminRights.Location = new System.Drawing.Point(3, 151);
            this.adminRights.Name = "adminRights";
            this.adminRights.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.adminRights.Size = new System.Drawing.Size(165, 21);
            this.adminRights.TabIndex = 26;
            this.adminRights.Text = "Права администратора";
            this.adminRights.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Фамилия Имя Отчество";
            // 
            // fullNameTB
            // 
            this.fullNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullNameTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fullNameTB.Location = new System.Drawing.Point(0, 120);
            this.fullNameTB.Name = "fullNameTB";
            this.fullNameTB.Size = new System.Drawing.Size(201, 25);
            this.fullNameTB.TabIndex = 23;
            this.fullNameTB.Enter += new System.EventHandler(this.FocusEntered);
            // 
            // passwTB
            // 
            this.passwTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwTB.Location = new System.Drawing.Point(0, 72);
            this.passwTB.Name = "passwTB";
            this.passwTB.Size = new System.Drawing.Size(201, 25);
            this.passwTB.TabIndex = 22;
            this.passwTB.Enter += new System.EventHandler(this.FocusEntered);
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
            this.saveButton.Location = new System.Drawing.Point(0, 192);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(201, 32);
            this.saveButton.TabIndex = 21;
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.saveButton, "Применить");
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            this.saveButton.Enter += new System.EventHandler(this.FocusEntered);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Пароль";
            // 
            // loginTB
            // 
            this.loginTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginTB.Location = new System.Drawing.Point(0, 24);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(201, 25);
            this.loginTB.TabIndex = 10;
            this.loginTB.Enter += new System.EventHandler(this.FocusEntered);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Логин";
            // 
            // extSearchbutton
            // 
            this.extSearchbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.extSearchbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.extSearchbutton.FlatAppearance.BorderSize = 0;
            this.extSearchbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(18)))), ((int)(((byte)(89)))));
            this.extSearchbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(109)))), ((int)(((byte)(196)))));
            this.extSearchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extSearchbutton.Font = new System.Drawing.Font("Meiryo", 10F, System.Drawing.FontStyle.Bold);
            this.extSearchbutton.ForeColor = System.Drawing.Color.White;
            this.extSearchbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.extSearchbutton.Location = new System.Drawing.Point(0, 120);
            this.extSearchbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.extSearchbutton.Name = "extSearchbutton";
            this.extSearchbutton.Size = new System.Drawing.Size(201, 40);
            this.extSearchbutton.TabIndex = 24;
            this.extSearchbutton.Text = "Поиск";
            this.extSearchbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.extSearchbutton.UseVisualStyleBackColor = false;
            this.extSearchbutton.Click += new System.EventHandler(this.extSearchbutton_Click);
            this.extSearchbutton.Enter += new System.EventHandler(this.FocusEntered);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.backButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(18)))), ((int)(((byte)(89)))));
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(109)))), ((int)(((byte)(196)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Meiryo", 10F, System.Drawing.FontStyle.Bold);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(0, 418);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(201, 32);
            this.backButton.TabIndex = 22;
            this.backButton.Text = "Главная";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.Enter += new System.EventHandler(this.FocusEntered);
            // 
            // delButton
            // 
            this.delButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.delButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.delButton.FlatAppearance.BorderSize = 0;
            this.delButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(18)))), ((int)(((byte)(89)))));
            this.delButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(109)))), ((int)(((byte)(196)))));
            this.delButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delButton.Font = new System.Drawing.Font("Meiryo", 10F, System.Drawing.FontStyle.Bold);
            this.delButton.ForeColor = System.Drawing.Color.White;
            this.delButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delButton.Location = new System.Drawing.Point(0, 80);
            this.delButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(201, 40);
            this.delButton.TabIndex = 4;
            this.delButton.Text = "Удалить";
            this.delButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delButton.UseVisualStyleBackColor = false;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            this.delButton.Enter += new System.EventHandler(this.FocusEntered);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.editButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(18)))), ((int)(((byte)(89)))));
            this.editButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(109)))), ((int)(((byte)(196)))));
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Meiryo", 10F, System.Drawing.FontStyle.Bold);
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editButton.Location = new System.Drawing.Point(0, 40);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(201, 40);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Редактировать";
            this.editButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            this.editButton.Enter += new System.EventHandler(this.FocusEntered);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.addButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(18)))), ((int)(((byte)(89)))));
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(109)))), ((int)(((byte)(196)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Meiryo", 10F, System.Drawing.FontStyle.Bold);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(0, 0);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(201, 40);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            this.addButton.Enter += new System.EventHandler(this.FocusEntered);
            // 
            // UsersForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.usersTable);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.moveToolsPanelPB);
            this.Controls.Add(this.toolsPanel);
            this.Font = new System.Drawing.Font("Meiryo", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователи";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UsersForm_FormClosed);
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveToolsPanelPB)).EndInit();
            this.toolsPanel.ResumeLayout(false);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView usersTable;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel recordsAmount;
        private System.Windows.Forms.ToolStripLabel recordsValue;
        private System.Windows.Forms.ToolStripSeparator Separator1;
        private System.Windows.Forms.ToolStripLabel selectedRecords;
        private System.Windows.Forms.ToolStripLabel valueSelectedRecords;
        private System.Windows.Forms.ToolStripSeparator Separator2;
        private System.Windows.Forms.ToolStripButton selectAllButton;
        private System.Windows.Forms.ToolStripSeparator Separator3;
        private System.Windows.Forms.ToolStripButton clearSelection;
        private System.Windows.Forms.ToolStripSeparator Separator4;
        private System.Windows.Forms.ToolStripLabel statusText;
        private System.Windows.Forms.PictureBox moveToolsPanelPB;
        private System.Windows.Forms.Panel toolsPanel;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.TextBox passwTB;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button extSearchbutton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fullNameTB;
        private System.Windows.Forms.CheckBox adminRights;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn HiddenPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IfAdmin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBox;
        private System.Windows.Forms.ToolTip toolTip;
    }
}