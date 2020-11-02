using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace ServiceAnother
{
    public partial class FormServiceTable : Form
    {
        Form homeForm;

        bool addClick = false;
        bool editClick = false;
        bool extSearchClick = false;

        int checkBoxColumnIndex = 4;
        int Id = 0;
        int index = -1;

        int ifAdmin = 0;

        string readQuery = "SELECT * FROM Service order by TechnicType asc";

        SQLiteConnection connection;
        SQLiteDataReader dataReader;
        SQLiteCommand cmd;

        public FormServiceTable()
        {
            InitializeComponent();
        }
        public FormServiceTable(SQLiteConnection _connection, Form _homeForm, int _ifAdmin)
        {
            InitializeComponent();

            connection = _connection;
            homeForm = _homeForm;
            ifAdmin = _ifAdmin;
        }
        private void FormServiceTable_Load(object sender, EventArgs e)
        {
            ReadServiceTable(readQuery);
            valueSelectedRecords.Text = "0";
            switch (Convert.ToBoolean(ifAdmin))
            {
                case true:
                    editButton.Enabled = true;
                    delButton.Enabled = true;
                    addButton.Enabled = true;
                    break;
                case false:
                    editButton.Enabled = false;
                    delButton.Enabled = false;
                    addButton.Enabled = false;
                    break;
            }
        }
        private void ReadServiceTable(string readQuery)
        {
            serviceTable.Rows.Clear();

            cmd = new SQLiteCommand(readQuery, connection);
            dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    int rows = serviceTable.Rows.Add();
                    serviceTable.Rows[rows].Cells[0].Value = dataReader[0];
                    serviceTable.Rows[rows].Cells[1].Value = dataReader[1];
                    serviceTable.Rows[rows].Cells[2].Value = dataReader[2];
                    serviceTable.Rows[rows].Cells[3].Value = dataReader[3];
                }
            }
            else
            {
                if (extSearchClick)
                {
                    statusText.Text = "По запросу ничего не найдено";
                }
            }

            dataReader.Close();
            recordsValue.Text = serviceTable.Rows.Count.ToString();
        }
        private void moveToolsPanelPB_Click(object sender, EventArgs e)
        {
            toolsPanel.Visible = toolsPanel.Visible = true ^ toolsPanel.Visible;

            inputPanel.Visible = false;

            editButton.Visible = true;
            delButton.Visible = true;
            addButton.Visible = true;
            sendButton.Visible = true;
            extSearchbutton.Visible = true;

            if (extSearchClick)
            {
                ReadServiceTable(readQuery);
            }

            addClick = false;
            editClick = false;
            extSearchClick = false;
            statusText.Text = "";

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            clearSelection_Click(sender, e);
            if (!addClick)
            {
                inputPanel.Visible = true;
                ButtonVisibleFalse(editButton, delButton, sendButton, extSearchbutton);
                addClick = true;

                techTypeTB.Clear();
                repTypeTB.Clear();
                costTB.Clear();
            }
            else
            {
                inputPanel.Visible = false;
                ButtonVisibleTrue(editButton, delButton, sendButton, extSearchbutton);
                addClick = false;
            }
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            if (!editClick)
            {
                if (index < 0)
                {
                    statusText.Text = "Выберите запись";
                }
                else
                {
                    inputPanel.Visible = true;
                    ButtonVisibleFalse(addButton, delButton, sendButton, extSearchbutton);
                    editClick = true;

                }
            }
            else
            {
                inputPanel.Visible = false;
                ButtonVisibleTrue(addButton, delButton, sendButton, extSearchbutton);
                editClick = false;
            }
        }
        private void delButton_Click(object sender, EventArgs e)
        {
            int checkBoxColumnIndex = 4;
            if (index < 0)
            {
                statusText.Text = "Выберите запись";
            }
            else
            {
                for (int i = 0; i < serviceTable.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(serviceTable[checkBoxColumnIndex, i].Value))
                    {
                        Id = Convert.ToInt32(serviceTable[0, i].Value.ToString());

                        string delQuery = $"DELETE FROM Service WHERE ID = '{Id}'";
                        cmd = new SQLiteCommand(delQuery, connection);
                        cmd.ExecuteNonQuery();
                    }
                }
                valueSelectedRecords.Text = "0";

                ReadServiceTable(readQuery);
                index = -1;
            }
        }
        private void SendButton_Click(object sender, EventArgs e)
        {
            if (index > -1)
            {
                SendForm sendForm = new SendForm(serviceTable, Text, checkBoxColumnIndex, connection);
                sendForm.ShowDialog();
            }
            else
            {
                statusText.Text = "Выберите запись";
            }
        }
        private void extSearchbutton_Click(object sender, EventArgs e)
        {
            clearSelection_Click(sender, e);
            if (!extSearchClick)
            {
                inputPanel.Visible = true;
                ButtonVisibleFalse(editButton, delButton, addButton, addButton);
                extSearchClick = true;

                techTypeTB.Clear();
                repTypeTB.Clear();
                costTB.Clear();
            }
            else
            {
                inputPanel.Visible = false;
                ButtonVisibleTrue(editButton, delButton, addButton, addButton);
                extSearchClick = false;
                ReadServiceTable(readQuery);
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (extSearchClick)
            {
                if (String.IsNullOrWhiteSpace(techTypeTB.Text) &&
                    String.IsNullOrWhiteSpace(repTypeTB.Text) &&
                    String.IsNullOrWhiteSpace(costTB.Text))
                {

                    statusText.Text = "Должно быть заполнено хотя бы одно поле";
                }
                else
                {
                    SelectWhere();
                    valueSelectedRecords.Text = "0";
                }
            }
            else
            {
                if (String.IsNullOrWhiteSpace(techTypeTB.Text) ||
                    String.IsNullOrWhiteSpace(repTypeTB.Text) ||
                    String.IsNullOrWhiteSpace(costTB.Text))
                {

                    statusText.Text = "Не все поля заполнены";
                }
                else
                {
                    if (!double.TryParse(costTB.Text, out double cost) || cost <= 0)
                    {
                        statusText.Text = "Неверная стоимость";
                    }
                    else
                    {
                        if (ExistService(techTypeTB.Text, repTypeTB.Text, costTB.Text))
                        {
                            if (addClick)
                            {
                                InsertInto();
                            }
                            if (editClick)
                            {
                                UpdateSet();
                                CloseEditTool();
                            }
                            ReadServiceTable(readQuery);
                            valueSelectedRecords.Text = "0";
                        }
                    }
                }
            }
        }
        private void InsertInto()
        {
            string addQuery = $"INSERT INTO Service " +
                                    $"(TechnicType, RepairType, Cost)" +
                                    $"VALUES('{techTypeTB.Text}','{repTypeTB.Text}','{costTB.Text}')";
            cmd = new SQLiteCommand(addQuery, connection);
            cmd.ExecuteNonQuery();

            techTypeTB.Clear();
            repTypeTB.Clear();
            costTB.Clear();
        }
        private bool ExistService(string tType, string rTyep, string cost)
        {
            string checkQuery = $"SELECT * FROM Service WHERE " +
                $"TechnicType = '{tType}' AND " +
                $"RepairType = '{rTyep}' AND Cost = '{cost}'";
            cmd = new SQLiteCommand(checkQuery, connection);
            dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                statusText.Text = "Такая услуга уже существующествует";
                return false;
            }
            else
                return true;
        }
        private void UpdateSet()
        {
            string editQuery = $"UPDATE Service SET TechnicType = '{techTypeTB.Text}', " +
                           $"RepairType = '{repTypeTB.Text}', Cost = '{costTB.Text}'" +
                           $"WHERE ID = '{Id}'";
            cmd = new SQLiteCommand(editQuery, connection);
            cmd.ExecuteNonQuery();
        }
        private void SelectWhere()
        {
            serviceTable.Rows.Clear();


            string searchQuery = $"SELECT * FROM Service WHERE " +
                                 $"TechnicType LIKE '%{techTypeTB.Text}%' AND " +
                                 $"RepairType LIKE '%{repTypeTB.Text}%' AND " +
                                 $"Cost LIKE '%{costTB.Text}%'";

            ReadServiceTable(searchQuery);
        }
        private void ButtonVisibleTrue(Button bt1, Button bt2, Button bt3, Button bt4)
        {
            bt1.Visible = true;
            bt2.Visible = true;
            bt3.Visible = true;
            bt4.Visible = true;
        }
        private void ButtonVisibleFalse(Button bt1, Button bt2, Button bt3, Button bt4)
        {
            bt1.Visible = false;
            bt2.Visible = false;
            bt3.Visible = false;
            bt4.Visible = false;
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FormServiceTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            homeForm.Show();
        }
        private void serviceTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = -1;
            if (e.ColumnIndex == checkBoxColumnIndex)
            {
                if (Convert.ToBoolean(serviceTable.CurrentCell.Value))
                {
                    serviceTable.CurrentCell.Value = 0;
                }
                else
                {
                    serviceTable.CurrentCell.Value = 1;
                }
            }
            int selectedAmount = 0;

            for (int i = 0; i < serviceTable.Rows.Count; i++)
            {
                if (Convert.ToBoolean(serviceTable[checkBoxColumnIndex, i].Value))
                {
                    selectedAmount++;
                }
            }

            if (editClick && selectedAmount == 0)
            {
                CloseEditTool();
            }
            valueSelectedRecords.Text = selectedAmount.ToString();
            TextToTB();
        }
        private void clearSelection_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < serviceTable.Rows.Count; i++)
            {
                serviceTable[checkBoxColumnIndex, i].Value = 0;
            }
            index = -1;
            valueSelectedRecords.Text = "0";
            if (editClick)
            {
                CloseEditTool();
            }
        }
        private void selectAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < serviceTable.Rows.Count; i++)
            {
                serviceTable[checkBoxColumnIndex, i].Value = 1;
            }
            valueSelectedRecords.Text = serviceTable.Rows.Count.ToString();
            TextToTB();
        }
        private void FocusEntered(object sender, EventArgs e)
        {
            statusText.Text = "";
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        private void TextToTB()
        {
            for (int i = 0; i < serviceTable.RowCount; i++)
            {
                if (Convert.ToBoolean(serviceTable[checkBoxColumnIndex, i].Value))
                {
                    index = serviceTable[checkBoxColumnIndex, i].RowIndex;
                }
            }
            if (index > -1 && !addClick && !extSearchClick)
            {
                Id = Convert.ToInt32(serviceTable[0, index].Value.ToString());

                techTypeTB.Text = serviceTable[1, index].Value.ToString();
                repTypeTB.Text = serviceTable[2, index].Value.ToString();
                costTB.Text = serviceTable[3, index].Value.ToString();
            }
            else
            {
                techTypeTB.Clear();
                repTypeTB.Clear();
                costTB.Clear();
            }
        }
        private void CloseEditTool()
        {
            inputPanel.Visible = false;
            ButtonVisibleTrue(addButton, delButton, sendButton, extSearchbutton);
            editClick = false;
            index = -1;
        }
    }
}
