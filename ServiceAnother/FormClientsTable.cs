using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ServiceAnother
{
    public partial class FormClientsTable : Form
    {
        Form homeForm;

        bool addClick = false;
        bool editClick = false;
        bool extSearchClick = false;

        int checkBoxColumnIndex = 10;

        string userName;
        string readQuery;

        int Id = 0;
        int index = -1;
        int ifAdmin;

        double cost;

        SQLiteConnection connection;
        SQLiteDataReader dataReader;
        SQLiteCommand cmd;

        public FormClientsTable()
        {
            InitializeComponent();
        }
        public FormClientsTable(Form _homeForm, string _userName, int _ifAdmin, SQLiteConnection _connection)
        {
            InitializeComponent();
            homeForm = _homeForm;
            userName = _userName;
            ifAdmin = _ifAdmin;
            connection = _connection;

        }
        private void FormClientsTable_Load(object sender, EventArgs e)
        {
            if (ifAdmin == 1)
            {
                readQuery = "SELECT * FROM Clients ORDER BY FullName ASC";
                clientsTable.Columns[9].Visible = true;
            }
            else
            {
                readQuery = $"SELECT * FROM Clients WHERE User = '{userName}' ORDER BY FullName ASC";
                clientsTable.Columns[9].Visible = false;
            }

            ReadClientsTable(readQuery);
            valueSelectedRecords.Text = "0";

        }
        public void ReadClientsTable(string query)
        {
            clientsTable.Rows.Clear();
            cmd = new SQLiteCommand(query, connection);
            dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    int newRows = clientsTable.Rows.Add();

                    clientsTable.Rows[newRows].Cells[0].Value = dataReader[0];
                    clientsTable.Rows[newRows].Cells[1].Value = dataReader[1];
                    clientsTable.Rows[newRows].Cells[2].Value = dataReader[2];
                    clientsTable.Rows[newRows].Cells[3].Value = dataReader[3];
                    clientsTable.Rows[newRows].Cells[4].Value = dataReader[4];
                    clientsTable.Rows[newRows].Cells[5].Value = dataReader[5];
                    clientsTable.Rows[newRows].Cells[6].Value = dataReader[6];
                    clientsTable.Rows[newRows].Cells[7].Value = dataReader[7];
                    clientsTable.Rows[newRows].Cells[8].Value = dataReader[8];
                    clientsTable.Rows[newRows].Cells[9].Value = dataReader[9];
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

            techTypeCB.Items.Clear();
            query = "SELECT TechnicType FROM Service ORDER BY TechnicType ASC";
            cmd = new SQLiteCommand(query, connection);
            dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    if (!techTypeCB.Items.Contains(dataReader[0]))
                    {
                        techTypeCB.Items.Add(dataReader[0]);
                    }
                }
            }
            dataReader.Close();
            recordsValue.Text = clientsTable.Rows.Count.ToString();
        }/////////////Чтение данных из БД в DataGridView
        private void addButton_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            clearSelection_Click(sender, e);
            if (!addClick)
            {
                inputPanel.Visible = true;
                ButtonVisibleFalse(editButton, delButton, sendButton, extSearchbutton);
                addClick = true;
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
            if (index > -1)
            {
                if (!editClick)
                {
                    inputPanel.Visible = true;
                    ButtonVisibleFalse(addButton, delButton, sendButton, extSearchbutton);
                    editClick = true;
                }
                else
                {
                    inputPanel.Visible = false;
                    ButtonVisibleTrue(addButton, delButton, sendButton, extSearchbutton);
                    editClick = false;
                }
            }
            else
            {
                statusText.Text = "Выберите запись";
            }
        }
        private void delButton_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                statusText.Text = "Выберите запись";
            }
            else
            {
                for (int i = 0; i < clientsTable.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(clientsTable[checkBoxColumnIndex, i].Value))
                    {
                        Id = Convert.ToInt32(clientsTable[0, i].Value.ToString());

                        string delQuery = $"DELETE FROM Clients WHERE ID = '{Id}'";
                        cmd = new SQLiteCommand(delQuery, connection);
                        cmd.ExecuteNonQuery();
                    }
                }
                valueSelectedRecords.Text = "0";

                ReadClientsTable(readQuery);
                index = -1;
            }
        }
        private void sendButton_Click(object sender, EventArgs e)
        {
            if (index > -1)
            {
                SendForm sendForm = new SendForm(clientsTable, Text, checkBoxColumnIndex, connection);
                sendForm.ShowDialog();
            }
            else
            {
                statusText.Text = "Выберите запись";
            }
        }
        private void extSearchbutton_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            clearSelection_Click(sender, e);
            if (!extSearchClick)
            {
                inputPanel.Visible = true;
                ButtonVisibleFalse(editButton, delButton, addButton, addButton);
                extSearchClick = true;
                ordAccepDP.Visible = false;
                ordCompDP.Visible = false;
            }
            else
            {
                inputPanel.Visible = false;
                ButtonVisibleTrue(editButton, delButton, addButton, addButton);
                extSearchClick = false;
                ReadClientsTable(readQuery);
                ordAccepDP.Visible = true;
                ordCompDP.Visible = true;
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (extSearchClick)
            {
                if (String.IsNullOrWhiteSpace(fullNameTB.Text) &&
                    String.IsNullOrWhiteSpace(phNoTB.Text) &&
                    String.IsNullOrWhiteSpace(ordAccepTB.Text) &&
                    String.IsNullOrWhiteSpace(ordCompTB.Text) &&
                    techTypeCB.SelectedIndex == -1 &&
                    String.IsNullOrWhiteSpace(malfunctionTB.Text) &&
                    repTypeLB.Items.Count == 0)
                {
                    statusText.Text = "Должно быть заполнено хотя бы одно поле";
                }
                else
                {
                    if (CheckDate(ordAccepTB.Text, ordCompTB.Text) ||
                        CheckName(fullNameTB.Text) ||
                        CheckPhone(phNoTB.Text))
                    {
                        SelectWhere();
                    }
                }
            }
            else
            {
                if (String.IsNullOrWhiteSpace(fullNameTB.Text) ||
                    String.IsNullOrWhiteSpace(phNoTB.Text) ||
                    String.IsNullOrWhiteSpace(ordAccepDP.Text) ||
                    String.IsNullOrWhiteSpace(ordCompDP.Text) ||
                    techTypeCB.SelectedIndex == -1 ||
                    String.IsNullOrWhiteSpace(malfunctionTB.Text) ||
                    repTypeLB.Items.Count == 0)
                {
                    statusText.Text = "Не все поля заполнены";
                }
                else
                {
                    if (ordAccepDP.Value > ordCompDP.Value)
                    {
                        statusText.Text = "Неверная дата";
                    }
                    else
                    {
                        if (CheckName(fullNameTB.Text) &&
                            CheckPhone(phNoTB.Text))
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
                            ReadClientsTable(readQuery);
                            ClearTextBox();
                        }
                    }
                }
                valueSelectedRecords.Text = "0";
            }

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
                ReadClientsTable(readQuery);
            }

            addClick = false;
            editClick = false;
            extSearchClick = false;

            statusText.Text = "";

            ordAccepDP.Visible = true;
            ordCompDP.Visible = true;
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

        private void InsertInto()
        {
            CalculateCost();
            string repTypeValue = "";
            for (int i = 0; i < repTypeLB.Items.Count; i++)
            {
                repTypeValue += repTypeLB.Items[i];
                if (i < repTypeLB.Items.Count - 1)
                {
                    repTypeValue += "\n";
                }
            }
            string addQuery = $"INSERT INTO Clients " +
                              $"(FullName, PhoneNumber, OrderAccepted, OrderCompleted, TechnicType, Malfunction, RepairType, Cost, User)" +
                              $"VALUES(" +
                              $"'{fullNameTB.Text}', " +
                              $"'{phNoTB.Text}', " +
                              $"'{ordAccepDP.Value.ToShortDateString()}', " +
                              $"'{ordCompDP.Value.ToShortDateString()}', " +
                              $"'{techTypeCB.SelectedItem}', " +
                              $"'{malfunctionTB.Text}'," +
                              $"'{repTypeValue}', " +
                              $"'{cost}', " +
                              $"'{userName}')";

            cmd = new SQLiteCommand(addQuery, connection);
            cmd.ExecuteNonQuery();

            ClearTextBox();

            ReadClientsTable(readQuery);
        }//////////Выполнение запроса добавления в БД
        private void CalculateCost()
        {
            cost = 0;
            for (int i = 0; i < repTypeLB.Items.Count; i++)
            {
                string selectQuery = $"SELECT Cost FROM Service WHERE TechnicType = '{techTypeCB.SelectedItem}' AND " +
                                     $"RepairType = '{repTypeLB.Items[i]}'";
                cmd = new SQLiteCommand(selectQuery, connection);
                dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        cost += Convert.ToDouble(dataReader[0].ToString());
                    }
                }
                else
                {
                    cost = 0;
                }
            }
            double discount = 0;
            double discPercent = 0;

            if (cost >= 30 && cost < 50)
            {
                discPercent = 5;
            }
            if (cost >= 50 && cost < 100)
            {
                discPercent = 10;
            }
            if (cost >= 100)
            {
                discPercent = 25;
            }
            if (discPercent != 0)
            {
                discount = (cost * (discPercent / 100));
                cost -= discount;

                MessageBox.Show($"Скидка {discPercent}%!\nРазмер скидки: {discount}\nЦена со скидкой: {cost}", "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }


        }/////////Рассчет скидки
        private void UpdateSet()
        {
            CalculateCost();
            string repTypeValue = "";
            for (int i = 0; i < repTypeLB.Items.Count; i++)
            {
                repTypeValue += repTypeLB.Items[i];
                if (i < repTypeLB.Items.Count - 1)
                {
                    repTypeValue += "\n";
                }
            }
            string editQuery = $"UPDATE Clients SET " +
                               $"FullName = '{fullNameTB.Text}'," +
                               $"PhoneNumber = '{phNoTB.Text}', " +
                               $"OrderAccepted = '{ordAccepDP.Value.ToShortDateString()}', " +
                               $"OrderCompleted = '{ordCompDP.Value.ToShortDateString()}', " +
                               $"TechnicType = '{techTypeCB.SelectedItem}', " +
                               $"Malfunction = '{malfunctionTB.Text}', " +
                               $"RepairType = '{repTypeValue}', " +
                               $"Cost = '{cost}' " +
                               $"WHERE ID = '{Id}'";

            cmd = new SQLiteCommand(editQuery, connection);
            cmd.ExecuteNonQuery();

            ReadClientsTable(readQuery);
        }/////////Выполнение запроса обновленич данных БД
        private void SelectWhere()
        {
            string repTypeValue = "";
            for (int i = 0; i < repTypeLB.Items.Count; i++)
            {
                repTypeValue += repTypeLB.Items[i];
                if (i < repTypeLB.Items.Count - 1)
                {
                    repTypeValue += "\n";
                }
            }
            string searchQuery = $"SELECT * FROM Clients WHERE " +
                                 $"FullName LIKE '%{fullNameTB.Text}%' AND " +
                                 $"PhoneNumber LIKE '%{phNoTB.Text}%' AND " +
                                 $"OrderAccepted LIKE '%{ordAccepTB.Text}%' AND " +
                                 $"OrderCompleted LIKE '%{ordCompTB.Text}%' AND " +
                                 $"TechnicType LIKE '%{techTypeCB.SelectedItem}%' AND " +
                                 $"Malfunction LIKE '%{malfunctionTB.Text}%' AND " +
                                 $"RepairType LIKE '%{repTypeValue}%'";
            if (!Convert.ToBoolean(ifAdmin))
            {
                searchQuery += $" AND User = '{userName}'";
            }

            ReadClientsTable(searchQuery);

        }//////////////Выполнение запроса поиска в БД
        private void ClearTextBox()
        {
            fullNameTB.Clear();
            phNoTB.Clear();

            ordAccepTB.Clear();
            ordAccepDP.Value = DateTime.Now;
            ordCompTB.Clear();
            ordCompDP.Value = DateTime.Now;

            techTypeCB.SelectedIndex = -1;
            techTypeCB.Text = "";

            malfunctionTB.Clear();

            chooseRepTypeCB.SelectedIndex = -1;
            chooseRepTypeCB.Text = "";
            repTypeLB.Items.Clear();
        }

        private bool CheckDate(string ordAccep, string ordComp)
        {
            if ((DateTime.TryParse(ordAccep, out DateTime ordA) ||
                DateTime.TryParse(ordComp, out DateTime ordC)) ||
                (ordAccep.Length == 0 ||
                ordComp.Length == 0))
            {
                return true;
            }
            else
            {
                statusText.Text = "Неверная дата";
                return false;
            }
        }//////////////Проверка введенной даты
        private bool CheckName(string fullName)
        {
            bool isLetter = true;

            for (int i = 0; i < fullName.Length; i++)
            {
                if (!Char.IsLetter(fullName[i]) && !Char.IsWhiteSpace(fullName[i]))
                {
                    isLetter = false;
                    statusText.Text = "Неверное ФИО";
                    break;
                }
            }
            return isLetter;
        }//////////////Проверка введенного ФИО
        private bool CheckPhone(string phNo)
        {
            bool isDigit = true;

            for (int i = 0; i < phNo.Length; i++)
            {
                if (!Char.IsDigit(phNo[i]) && !Char.IsWhiteSpace(phNo[i]))
                {
                    isDigit = false;
                    statusText.Text = "Неверный телефон";
                    break;
                }
            }
            return isDigit;
        }//////////////Проверка телефона

        private void techTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (techTypeCB.SelectedIndex != -1)
            {
                chooseRepTypeCB.Items.Clear();
                string techType = techTypeCB.SelectedItem.ToString();
                string query = $"SELECT RepairType FROM [Service] WHERE TechnicType='{techType}' ORDER BY RepairType ASC";

                cmd = new SQLiteCommand(query, connection);
                dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        chooseRepTypeCB.Items.Add(dataReader[0]);
                    }
                }
                dataReader.Close();
            }
        }
        private void clientsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = -1;
            if (e.ColumnIndex == checkBoxColumnIndex)
            {
                if (Convert.ToBoolean(clientsTable.CurrentCell.Value))
                {
                    clientsTable.CurrentCell.Value = 0;
                }
                else
                {
                    clientsTable.CurrentCell.Value = 1;
                }
            }
            int selectedAmount = 0;

            for (int i = 0; i < clientsTable.Rows.Count; i++)
            {
                if (Convert.ToBoolean(clientsTable[checkBoxColumnIndex, i].Value))
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
        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FormClientsTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            homeForm.Show();
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
        private void selectAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clientsTable.Rows.Count; i++)
            {
                clientsTable[checkBoxColumnIndex, i].Value = 1;
            }
            valueSelectedRecords.Text = clientsTable.Rows.Count.ToString();
            TextToTB();
        }
        private void clearSelection_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clientsTable.Rows.Count; i++)
            {
                clientsTable[checkBoxColumnIndex, i].Value = 0;
            }
            index = -1;
            valueSelectedRecords.Text = "0";
            if (editClick)
            {
                CloseEditTool();
            }
        }

        private void FocusEntered(object sender, EventArgs e)
        {
            statusText.Text = "";
        }
        private void TextToTB()
        {
            for (int i = 0; i < clientsTable.RowCount; i++)
            {
                if (Convert.ToBoolean(clientsTable[checkBoxColumnIndex, i].Value))
                {
                    index = clientsTable[checkBoxColumnIndex, i].RowIndex;
                }
            }
            if (index > -1 && !addClick && !extSearchClick)
            {
                Id = Convert.ToInt32(clientsTable[0, index].Value.ToString());

                fullNameTB.Text = clientsTable[1, index].Value.ToString();
                phNoTB.Text = clientsTable[2, index].Value.ToString();
                ordAccepDP.Text = clientsTable[3, index].Value.ToString();
                ordCompDP.Text = clientsTable[4, index].Value.ToString();
                techTypeCB.Text = clientsTable[5, index].Value.ToString();
                malfunctionTB.Text = clientsTable[6, index].Value.ToString();

                var tmp = clientsTable[7, index].Value.ToString().Split(new char[] { '\n' });
                for (int i = 0; i < tmp.Length; i++)
                {
                    repTypeLB.Items.Add(tmp[i]);
                }
            }
            else
            {
                ClearTextBox();
            }
        }///////////Текст из DataGridView записывается в TextBox
        private void plusButton_Click(object sender, EventArgs e)
        {
            if (chooseRepTypeCB.SelectedIndex != -1)
            {
                if (!repTypeLB.Items.Contains(chooseRepTypeCB.SelectedItem.ToString()))
                {
                    repTypeLB.Items.Add(chooseRepTypeCB.SelectedItem);
                }
            }
        }
        private void minusButton_Click(object sender, EventArgs e)
        {
            if (repTypeLB.SelectedIndex != -1)
            {
                repTypeLB.Items.RemoveAt(repTypeLB.SelectedIndex);
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

