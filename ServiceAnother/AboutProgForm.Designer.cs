namespace ServiceAnother
{
    partial class AboutProgForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Добавить");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Редактировать");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Удалить");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Поиск");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Окно Клиенты", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Добавить");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Редактировать");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Удалить");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Поиск");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Окно Услуги", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Добавить");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Редактировать");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Удалить");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Поиск");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Окно пользователи", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Окно отправки");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutProgForm));
            this.helpCategory = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.viewTB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // helpCategory
            // 
            this.helpCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.helpCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.helpCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.helpCategory.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.helpCategory.Location = new System.Drawing.Point(10, 10);
            this.helpCategory.Name = "helpCategory";
            treeNode1.Name = "AddClient";
            treeNode1.Text = "Добавить";
            treeNode2.Name = "EditClient";
            treeNode2.Text = "Редактировать";
            treeNode3.Name = "DelClient";
            treeNode3.Text = "Удалить";
            treeNode4.Name = "SearchClients";
            treeNode4.Text = "Поиск";
            treeNode5.Name = "Clients";
            treeNode5.Text = "Окно Клиенты";
            treeNode6.Name = "AddService";
            treeNode6.Text = "Добавить";
            treeNode7.Name = "EditService";
            treeNode7.Text = "Редактировать";
            treeNode8.Name = "DelService";
            treeNode8.Text = "Удалить";
            treeNode9.Name = "SearchService";
            treeNode9.Text = "Поиск";
            treeNode10.Name = "Service";
            treeNode10.Text = "Окно Услуги";
            treeNode11.Name = "AddUser";
            treeNode11.Text = "Добавить";
            treeNode12.Name = "EditUser";
            treeNode12.Text = "Редактировать";
            treeNode13.Name = "DelUser";
            treeNode13.Text = "Удалить";
            treeNode14.Name = "SearchUser";
            treeNode14.Text = "Поиск";
            treeNode15.Name = "Users";
            treeNode15.Text = "Окно пользователи";
            treeNode16.Name = "Send";
            treeNode16.Text = "Окно отправки";
            this.helpCategory.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode10,
            treeNode15,
            treeNode16});
            this.helpCategory.Size = new System.Drawing.Size(191, 372);
            this.helpCategory.TabIndex = 0;
            this.helpCategory.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.helpCategory_NodeMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ElecPair";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "v3.0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(201, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 43);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Разработчик: Лявдоньская В.С.";
            // 
            // viewTB
            // 
            this.viewTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.viewTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewTB.Location = new System.Drawing.Point(207, 52);
            this.viewTB.Multiline = true;
            this.viewTB.Name = "viewTB";
            this.viewTB.ReadOnly = true;
            this.viewTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.viewTB.Size = new System.Drawing.Size(410, 330);
            this.viewTB.TabIndex = 5;
            // 
            // AboutProgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.ClientSize = new System.Drawing.Size(627, 392);
            this.Controls.Add(this.viewTB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.helpCategory);
            this.Font = new System.Drawing.Font("Meiryo", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutProgForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справка";
            this.Load += new System.EventHandler(this.AboutProgForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView helpCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox viewTB;
        private System.Windows.Forms.Label label3;
    }
}
