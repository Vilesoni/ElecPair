namespace ServiceAnother
{
    partial class FormClientsTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientsTable));
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.sendButton = new System.Windows.Forms.Button();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.repTypeLB = new System.Windows.Forms.ListBox();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.ordCompDP = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.ordAccepDP = new System.Windows.Forms.DateTimePicker();
            this.malfunctionTB = new System.Windows.Forms.TextBox();
            this.ordCompTB = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.ordAccepTB = new System.Windows.Forms.TextBox();
            this.chooseRepTypeCB = new System.Windows.Forms.ComboBox();
            this.phNoTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fullNameTB = new System.Windows.Forms.TextBox();
            this.techTypeCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.extSearchbutton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
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
            this.clientsTable = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdAccep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdComp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TechType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Malfunction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.moveToolsPanelPB = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolsPanel.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveToolsPanelPB)).BeginInit();
            this.SuspendLayout();
            // 
            // toolsPanel
            // 
            this.toolsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.toolsPanel.Controls.Add(this.sendButton);
            this.toolsPanel.Controls.Add(this.inputPanel);
            this.toolsPanel.Controls.Add(this.extSearchbutton);
            this.toolsPanel.Controls.Add(this.backButton);
            this.toolsPanel.Controls.Add(this.delButton);
            this.toolsPanel.Controls.Add(this.editButton);
            this.toolsPanel.Controls.Add(this.addButton);
            this.toolsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolsPanel.Location = new System.Drawing.Point(0, 0);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(200, 701);
            this.toolsPanel.TabIndex = 0;
            this.toolsPanel.Visible = false;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.sendButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sendButton.FlatAppearance.BorderSize = 0;
            this.sendButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(18)))), ((int)(((byte)(89)))));
            this.sendButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(109)))), ((int)(((byte)(196)))));
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Font = new System.Drawing.Font("Meiryo", 10F, System.Drawing.FontStyle.Bold);
            this.sendButton.ForeColor = System.Drawing.Color.White;
            this.sendButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sendButton.Location = new System.Drawing.Point(0, 629);
            this.sendButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(200, 40);
            this.sendButton.TabIndex = 24;
            this.sendButton.Text = "Отправить";
            this.sendButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            this.sendButton.Enter += new System.EventHandler(this.FocusEntered);
            // 
            // inputPanel
            // 
            this.inputPanel.Controls.Add(this.repTypeLB);
            this.inputPanel.Controls.Add(this.minusButton);
            this.inputPanel.Controls.Add(this.plusButton);
            this.inputPanel.Controls.Add(this.ordCompDP);
            this.inputPanel.Controls.Add(this.label7);
            this.inputPanel.Controls.Add(this.ordAccepDP);
            this.inputPanel.Controls.Add(this.malfunctionTB);
            this.inputPanel.Controls.Add(this.ordCompTB);
            this.inputPanel.Controls.Add(this.saveButton);
            this.inputPanel.Controls.Add(this.ordAccepTB);
            this.inputPanel.Controls.Add(this.chooseRepTypeCB);
            this.inputPanel.Controls.Add(this.phNoTB);
            this.inputPanel.Controls.Add(this.label6);
            this.inputPanel.Controls.Add(this.fullNameTB);
            this.inputPanel.Controls.Add(this.techTypeCB);
            this.inputPanel.Controls.Add(this.label5);
            this.inputPanel.Controls.Add(this.label4);
            this.inputPanel.Controls.Add(this.label3);
            this.inputPanel.Controls.Add(this.label1);
            this.inputPanel.Controls.Add(this.label2);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputPanel.Location = new System.Drawing.Point(0, 160);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(200, 452);
            this.inputPanel.TabIndex = 7;
            this.inputPanel.Visible = false;
            // 
            // repTypeLB
            // 
            this.repTypeLB.FormattingEnabled = true;
            this.repTypeLB.ItemHeight = 18;
            this.repTypeLB.Location = new System.Drawing.Point(0, 345);
            this.repTypeLB.Name = "repTypeLB";
            this.repTypeLB.ScrollAlwaysVisible = true;
            this.repTypeLB.Size = new System.Drawing.Size(200, 40);
            this.repTypeLB.TabIndex = 21;
            this.repTypeLB.Enter += new System.EventHandler(this.FocusEntered);
            // 
            // minusButton
            // 
            this.minusButton.Image = global::ServiceAnother.Properties.Resources.cross15;
            this.minusButton.Location = new System.Drawing.Point(26, 391);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(20, 20);
            this.minusButton.TabIndex = 24;
            this.minusButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolTip.SetToolTip(this.minusButton, "Удалить вид работ");
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            this.minusButton.Enter += new System.EventHandler(this.FocusEntered);
            // 
            // plusButton
            // 
            this.plusButton.Image = global::ServiceAnother.Properties.Resources.plus15;
            this.plusButton.Location = new System.Drawing.Point(0, 391);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(20, 20);
            this.plusButton.TabIndex = 22;
            this.plusButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolTip.SetToolTip(this.plusButton, "Добавить вид работ");
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            this.plusButton.Enter += new System.EventHandler(this.FocusEntered);
            // 
            // ordCompDP
            // 
            this.ordCompDP.Location = new System.Drawing.Point(0, 168);
            this.ordCompDP.Name = "ordCompDP";
            this.ordCompDP.Size = new System.Drawing.Size(200, 25);
            this.ordCompDP.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Meiryo", 8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Заявленная неисправность";
            // 
            // ordAccepDP
            // 
            this.ordAccepDP.Location = new System.Drawing.Point(0, 120);
            this.ordAccepDP.Name = "ordAccepDP";
            this.ordAccepDP.Size = new System.Drawing.Size(200, 25);
            this.ordAccepDP.TabIndex = 21;
            // 
            // malfunctionTB
            // 
            this.malfunctionTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.malfunctionTB.Location = new System.Drawing.Point(0, 265);
            this.malfunctionTB.Name = "malfunctionTB";
            this.malfunctionTB.Size = new System.Drawing.Size(200, 25);
            this.malfunctionTB.TabIndex = 22;
            this.malfunctionTB.Enter += new System.EventHandler(this.FocusEntered);
            // 
            // ordCompTB
            // 
            this.ordCompTB.Location = new System.Drawing.Point(0, 168);
            this.ordCompTB.Name = "ordCompTB";
            this.ordCompTB.Size = new System.Drawing.Size(200, 25);
            this.ordCompTB.TabIndex = 10;
            this.ordCompTB.Enter += new System.EventHandler(this.FocusEntered);
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
            this.saveButton.Location = new System.Drawing.Point(0, 420);
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
            // ordAccepTB
            // 
            this.ordAccepTB.Location = new System.Drawing.Point(0, 120);
            this.ordAccepTB.Name = "ordAccepTB";
            this.ordAccepTB.Size = new System.Drawing.Size(200, 25);
            this.ordAccepTB.TabIndex = 9;
            this.ordAccepTB.Enter += new System.EventHandler(this.FocusEntered);
            // 
            // chooseRepTypeCB
            // 
            this.chooseRepTypeCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseRepTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseRepTypeCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chooseRepTypeCB.FormattingEnabled = true;
            this.chooseRepTypeCB.Location = new System.Drawing.Point(0, 313);
            this.chooseRepTypeCB.Name = "chooseRepTypeCB";
            this.chooseRepTypeCB.Size = new System.Drawing.Size(200, 26);
            this.chooseRepTypeCB.Sorted = true;
            this.chooseRepTypeCB.TabIndex = 20;
            this.chooseRepTypeCB.Enter += new System.EventHandler(this.FocusEntered);
            // 
            // phNoTB
            // 
            this.phNoTB.Location = new System.Drawing.Point(0, 72);
            this.phNoTB.MaxLength = 13;
            this.phNoTB.Name = "phNoTB";
            this.phNoTB.Size = new System.Drawing.Size(200, 25);
            this.phNoTB.TabIndex = 8;
            this.phNoTB.Enter += new System.EventHandler(this.FocusEntered);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Meiryo", 8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Вид работ";
            // 
            // fullNameTB
            // 
            this.fullNameTB.Location = new System.Drawing.Point(0, 24);
            this.fullNameTB.Name = "fullNameTB";
            this.fullNameTB.Size = new System.Drawing.Size(200, 25);
            this.fullNameTB.TabIndex = 7;
            this.fullNameTB.Enter += new System.EventHandler(this.FocusEntered);
            // 
            // techTypeCB
            // 
            this.techTypeCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.techTypeCB.AutoCompleteCustomSource.AddRange(new string[] {
            "ПК",
            "Мобильный телефон",
            "ПК/Ноутбук",
            "Ноутбук"});
            this.techTypeCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.techTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.techTypeCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.techTypeCB.FormattingEnabled = true;
            this.techTypeCB.Location = new System.Drawing.Point(0, 216);
            this.techTypeCB.Name = "techTypeCB";
            this.techTypeCB.Size = new System.Drawing.Size(200, 26);
            this.techTypeCB.Sorted = true;
            this.techTypeCB.TabIndex = 18;
            this.techTypeCB.SelectedIndexChanged += new System.EventHandler(this.techTypeCB_SelectedIndexChanged);
            this.techTypeCB.Enter += new System.EventHandler(this.FocusEntered);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Meiryo", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Принятое оборудование";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Дата выдачи";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Дата приема";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Телефон";
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
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Фамилия Имя Отчество";
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
            this.extSearchbutton.Size = new System.Drawing.Size(200, 40);
            this.extSearchbutton.TabIndex = 23;
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
            this.backButton.Location = new System.Drawing.Point(0, 669);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(200, 32);
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
            this.delButton.Size = new System.Drawing.Size(200, 40);
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
            this.editButton.Size = new System.Drawing.Size(200, 40);
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
            this.addButton.Size = new System.Drawing.Size(200, 40);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            this.addButton.Enter += new System.EventHandler(this.FocusEntered);
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
            this.toolStrip1.Location = new System.Drawing.Point(232, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(930, 25);
            this.toolStrip1.TabIndex = 19;
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
            // clientsTable
            // 
            this.clientsTable.AllowUserToAddRows = false;
            this.clientsTable.AllowUserToDeleteRows = false;
            this.clientsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(185)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clientsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.clientsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientsTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.clientsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.clientsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Meiryo", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.clientsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.FullName,
            this.PhNo,
            this.OrdAccep,
            this.OrdComp,
            this.TechType,
            this.Malfunction,
            this.RepType,
            this.Sum,
            this.User,
            this.CheckBox});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Meiryo", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(170)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clientsTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.clientsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsTable.EnableHeadersVisualStyles = false;
            this.clientsTable.Location = new System.Drawing.Point(232, 25);
            this.clientsTable.Name = "clientsTable";
            this.clientsTable.ReadOnly = true;
            this.clientsTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.clientsTable.RowHeadersVisible = false;
            this.clientsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsTable.Size = new System.Drawing.Size(930, 676);
            this.clientsTable.TabIndex = 20;
            this.clientsTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsTable_CellClick);
            // 
            // num
            // 
            this.num.HeaderText = "ID";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Visible = false;
            // 
            // FullName
            // 
            this.FullName.FillWeight = 102.6831F;
            this.FullName.HeaderText = "ФИО";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // PhNo
            // 
            this.PhNo.FillWeight = 102.6831F;
            this.PhNo.HeaderText = "Телефон";
            this.PhNo.Name = "PhNo";
            this.PhNo.ReadOnly = true;
            // 
            // OrdAccep
            // 
            this.OrdAccep.FillWeight = 102.6831F;
            this.OrdAccep.HeaderText = "Дата приема";
            this.OrdAccep.Name = "OrdAccep";
            this.OrdAccep.ReadOnly = true;
            // 
            // OrdComp
            // 
            this.OrdComp.FillWeight = 102.6831F;
            this.OrdComp.HeaderText = "Дата выдачи";
            this.OrdComp.Name = "OrdComp";
            this.OrdComp.ReadOnly = true;
            // 
            // TechType
            // 
            this.TechType.FillWeight = 102.6831F;
            this.TechType.HeaderText = "Принятое оборудование";
            this.TechType.Name = "TechType";
            this.TechType.ReadOnly = true;
            // 
            // Malfunction
            // 
            this.Malfunction.HeaderText = "Заявленная неисправность";
            this.Malfunction.Name = "Malfunction";
            this.Malfunction.ReadOnly = true;
            // 
            // RepType
            // 
            this.RepType.FillWeight = 102.6831F;
            this.RepType.HeaderText = "Вид работ";
            this.RepType.Name = "RepType";
            this.RepType.ReadOnly = true;
            // 
            // Sum
            // 
            this.Sum.FillWeight = 102.6831F;
            this.Sum.HeaderText = "Сумма, руб";
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            // 
            // User
            // 
            this.User.HeaderText = "Пользователь";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Visible = false;
            // 
            // CheckBox
            // 
            this.CheckBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CheckBox.FillWeight = 20F;
            this.CheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBox.HeaderText = "";
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.ReadOnly = true;
            // 
            // moveToolsPanelPB
            // 
            this.moveToolsPanelPB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.moveToolsPanelPB.Dock = System.Windows.Forms.DockStyle.Left;
            this.moveToolsPanelPB.Image = global::ServiceAnother.Properties.Resources.menu32;
            this.moveToolsPanelPB.Location = new System.Drawing.Point(200, 0);
            this.moveToolsPanelPB.Name = "moveToolsPanelPB";
            this.moveToolsPanelPB.Size = new System.Drawing.Size(32, 701);
            this.moveToolsPanelPB.TabIndex = 2;
            this.moveToolsPanelPB.TabStop = false;
            this.moveToolsPanelPB.Click += new System.EventHandler(this.moveToolsPanelPB_Click);
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(109)))), ((int)(((byte)(196)))));
            this.toolTip.ForeColor = System.Drawing.Color.White;
            // 
            // FormClientsTable
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1162, 701);
            this.Controls.Add(this.clientsTable);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.moveToolsPanelPB);
            this.Controls.Add(this.toolsPanel);
            this.Font = new System.Drawing.Font("Meiryo", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "FormClientsTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиенты";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClientsTable_FormClosed);
            this.Load += new System.EventHandler(this.FormClientsTable_Load);
            this.toolsPanel.ResumeLayout(false);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveToolsPanelPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toolsPanel;
        private System.Windows.Forms.PictureBox moveToolsPanelPB;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button extSearchbutton;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox chooseRepTypeCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox techTypeCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox ordCompTB;
        private System.Windows.Forms.TextBox ordAccepTB;
        private System.Windows.Forms.TextBox phNoTB;
        private System.Windows.Forms.TextBox fullNameTB;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox malfunctionTB;
        private System.Windows.Forms.DateTimePicker ordAccepDP;
        private System.Windows.Forms.DateTimePicker ordCompDP;
        public System.Windows.Forms.DataGridView clientsTable;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.ListBox repTypeLB;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdAccep;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TechType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malfunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBox;
    }
}