using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ServiceAnother
{
    public partial class UsersForm : Form
    {
        Form homeForm;

        SQLiteConnection connection;
        SQLiteDataReader dataReader;
        SQLiteCommand cmd;

        bool addClick = false;
        bool editClick = false;
        bool extSearchClick = false;

        int checkBoxColumnIndex = 6;
        int Id = 0;
        int index = -1;

        int passwordColumnIndex = 2;

        string[] previousValues = new string[4];

        string readQuery = "SELECT * FROM Users order by UserName asc";
        public UsersForm(SQLiteConnection _connection, Form _homeForm)
        {
            InitializeComponent();

            connection = _connection;
            homeForm = _homeForm;
        }
        private void UsersForm_Load(object sender, EventArgs e)
        {
            ReadUsersTable(readQuery);
            valueSelectedRecords.Text = "0";
        }
        private void ReadUsersTable(string readQuery)
        {
            usersTable.Rows.Clear();
          
            cmd = new SQLiteCommand(readQuery, connection);
            dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    int rows = usersTable.Rows.Add();
                    usersTable.Rows[rows].Cells[0].Value = dataReader[0];
                    usersTable.Rows[rows].Cells[1].Value = dataReader[1];
                    usersTable.Rows[rows].Cells[2].Value = dataReader[2];
                    usersTable.Rows[rows].Cells[3].Value = dataReader[2];
                    usersTable.Rows[rows].Cells[4].Value = dataReader[3];

                    switch (Convert.ToInt32(dataReader[4].ToString()))
                    {
                        case 1:
                            usersTable.Rows[rows].Cells[5].Value = "Да";
                            break;
                        case 0:
                            usersTable.Rows[rows].Cells[5].Value = "Нет";
                            break;
                    }
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
            recordsValue.Text = usersTable.Rows.Count.ToString();
        }
        private void moveToolsPanelPB_Click(object sender, EventArgs e)
        {
            toolsPanel.Visible = toolsPanel.Visible = true ^ toolsPanel.Visible;

            inputPanel.Visible = false;

            editButton.Visible = true;
            delButton.Visible = true;
            addButton.Visible = true;
            extSearchbutton.Visible = true;

            if (extSearchClick)
            {
                ReadUsersTable(readQuery);
            }

            addClick = false;
            editClick = false;
            extSearchClick = false;

            statusText.Text = "";
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            loginTB.ReadOnly = false;
            passwTB.ReadOnly = false;
            fullNameTB.ReadOnly = false;
            adminRights.Enabled = true;
            ClearFields();
            clearSelection_Click(sender, e);
            if (!addClick)
            {
                inputPanel.Visible = true;
                ButtonVisibleFalse(editButton, delButton, delButton, extSearchbutton);
                addClick = true;
               
            }
            else
            {
                inputPanel.Visible = false;
                ButtonVisibleTrue(editButton, delButton, delButton, extSearchbutton);
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
                    ButtonVisibleFalse(addButton, delButton, delButton, extSearchbutton);
                    editClick = true;
                }
            }
            else
            {
                inputPanel.Visible = false;
                ButtonVisibleTrue(addButton, delButton, delButton, extSearchbutton);
                editClick = false;
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
                for (int i = 0; i < usersTable.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(usersTable[checkBoxColumnIndex, i].Value))
                    {
                        Id = Convert.ToInt32(usersTable[0, i].Value.ToString());

                        string delQuery = $"DELETE FROM Users WHERE ID = '{Id}'";
                        cmd = new SQLiteCommand(delQuery, connection);
                        cmd.ExecuteNonQuery();
                    }
                }
                valueSelectedRecords.Text = "0";

                ReadUsersTable(readQuery);
            }
        }
        private void extSearchbutton_Click(object sender, EventArgs e)
        {
            ClearFields();
            clearSelection_Click(sender, e);
            if (!extSearchClick)
            {
                inputPanel.Visible = true;
                ButtonVisibleFalse(editButton, delButton, addButton, addButton);
                extSearchClick = true;
                adminRights.Visible = false;

            }
            else
            {
                inputPanel.Visible = false;
                ButtonVisibleTrue(editButton, delButton, addButton, addButton);
                extSearchClick = false;
                adminRights.Visible = true;

                ReadUsersTable(readQuery);
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (extSearchClick)
            {
                if (String.IsNullOrWhiteSpace(loginTB.Text) &&
                    String.IsNullOrWhiteSpace(passwTB.Text) &&
                    String.IsNullOrWhiteSpace(fullNameTB.Text))
                {
                    statusText.Text = "Должно быть заполнено хотя бы одно поле";
                }
                else
                {
                    if (CheckName(fullNameTB.Text) ||
                        CheckLoginPassw(passwTB.Text) ||
                        CheckLoginPassw(loginTB.Text))
                    {
                        SelectWhere();
                    }
                }
            }
            else
            {
                if (String.IsNullOrWhiteSpace(loginTB.Text) &&
                    String.IsNullOrWhiteSpace(passwTB.Text) &&
                    String.IsNullOrWhiteSpace(fullNameTB.Text))
                {
                    statusText.Text = "Не все поля заполнены";
                }
                else
                {
                    if (CheckName(fullNameTB.Text) &&
                        CheckLoginPassw(passwTB.Text) &&
                        CheckLoginPassw(loginTB.Text))
                    {
                        if (addClick)
                        {
                            InsertInto();
                            ClearFields();
                        }
                        if (editClick)
                        {
                            UpdateSet();
                            if (!CheckExistAfterUpdate())
                            {
                                statusText.Text = "Такой пользователь уже существует";
                            }
                            else
                            {
                                CloseEditTool();
                            }
                        }
                        ReadUsersTable(readQuery);
                    }
                }
                valueSelectedRecords.Text = "0";
            }
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

        private bool CheckExist()
        {
            string checkQuery = $"SELECT UserName FROM Users WHERE UserName = '{loginTB.Text}'";
            cmd = new SQLiteCommand(checkQuery, connection);
            dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                statusText.Text = "Такой пользователь уже существует";
                dataReader.Close();
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool CheckExistAfterUpdate()
        {
            int count = 0;
            string countQuery = $"SELECT COUNT(UserName) FROM Users WHERE UserName = '{loginTB.Text}'";
            cmd = new SQLiteCommand(countQuery, connection);
            dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    count = Convert.ToInt32(dataReader[0].ToString());
                }
            }
            if (count > 1)
            {
                loginTB.Text = previousValues[0];
                passwTB.Text = previousValues[1];
                fullNameTB.Text = previousValues[2];
                switch (previousValues[3])
                {
                    case "Нет":
                        adminRights.Checked = false;
                        break;
                    case "Да":
                        adminRights.Checked = true;
                        break;
                }
                UpdateSet();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void InsertInto()
        {
            if (CheckExist())
            {
                string addQuery = $"INSERT INTO Users " +
                                  $"(UserName, Password, FullName, IfAdmin, IfSignIn)" +
                                  $"VALUES('{loginTB.Text}', " +
                                  $"'{passwTB.Text}', " +
                                  $"'{fullNameTB.Text}', " +
                                  $"'{Convert.ToInt32(adminRights.Checked)}', " +
                                  $"'{0}')";
                cmd = new SQLiteCommand(addQuery, connection);
                cmd.ExecuteNonQuery();

                ClearFields();
            }
        }
        private void UpdateSet()
        {
            string editQuery = $"UPDATE Users SET " +
                $"UserName = '{loginTB.Text}', " +
                $"Password = '{passwTB.Text}', " +
                $"FullName = '{fullNameTB.Text}', " +
                $"IfAdmin = '{Convert.ToInt32(adminRights.Checked)}' " +
                $"WHERE ID = '{Id}'";

            cmd = new SQLiteCommand(editQuery, connection);
            cmd.ExecuteNonQuery();

            string updClientsQuery = $"UPDATE Clients SET User = '{loginTB.Text}' WHERE User = '{previousValues[0]}'";
            cmd = new SQLiteCommand(updClientsQuery, connection);
            cmd.ExecuteNonQuery();

        }
        private void SelectWhere()
        {
            string searchQuery = $"SELECT * FROM Users WHERE " +
                                 $"UserName LIKE '%{loginTB.Text}%' AND " +
                                 $"Password LIKE '%{passwTB.Text}%' AND " +
                                 $"FullName LIKE '%{fullNameTB.Text}%'";


            ReadUsersTable(searchQuery);
        }
        private void UsersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            homeForm.Show();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
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

        private void usersTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == passwordColumnIndex && e.Value != null)
            {
                e.Value = new string('•', e.Value.ToString().Length);
            }
        }

        private void usersTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = -1;
            if (e.ColumnIndex == checkBoxColumnIndex)
            {
                if (Convert.ToBoolean(usersTable.CurrentCell.Value))
                {
                    usersTable.CurrentCell.Value = 0;
                }
                else
                {
                    usersTable.CurrentCell.Value = 1;
                }
            }
            int selectedAmount = 0;

            for (int i = 0; i < usersTable.Rows.Count; i++)
            {
                if (Convert.ToBoolean(usersTable[checkBoxColumnIndex, i].Value))
                {
                    selectedAmount++;
                }
            }
            valueSelectedRecords.Text = selectedAmount.ToString();
            if (editClick && selectedAmount == 0)
            {
                CloseEditTool();
            }

            TextToTB();
        }
        private void TextToTB()
        {
            for (int i = 0; i < usersTable.RowCount; i++)
            {
                if (Convert.ToBoolean(usersTable[checkBoxColumnIndex, i].Value))
                {
                    index = usersTable[checkBoxColumnIndex, i].RowIndex;
                }
            }
            if (index > -1)
            {
                Id = Convert.ToInt32(usersTable[0, index].Value.ToString());

                if (!addClick && !extSearchClick)
                {
                    previousValues[0] = usersTable[1, index].Value.ToString();
                    previousValues[1] = usersTable[2, index].Value.ToString();
                    previousValues[2] = usersTable[4, index].Value.ToString();
                    previousValues[3] = usersTable[5, index].Value.ToString();

                    loginTB.Text = usersTable[1, index].Value.ToString();

                    passwTB.Text = usersTable[2, index].Value.ToString();
                    fullNameTB.Text = usersTable[4, index].Value.ToString();

                    switch (usersTable[5, index].Value.ToString())
                    {
                        case "Нет":
                            adminRights.Checked = false;

                            loginTB.ReadOnly = false;
                            passwTB.ReadOnly = false;
                            fullNameTB.ReadOnly = false;
                            adminRights.Enabled = true;
                            break;
                        case "Да":
                            adminRights.Checked = true;
                            
                            loginTB.ReadOnly = true;
                            passwTB.ReadOnly = true;
                            fullNameTB.ReadOnly = true;
                            adminRights.Enabled = false;
                            break;
                    }

                }
            }
            else
            {
                ClearFields();
            }
        }
        private void FocusEntered(object sender, EventArgs e)
        {
            statusText.Text = "";
        }
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
        }
        private bool CheckLoginPassw(string lopas)
        {
            bool isLetterOrDigit = true;

            for (int i = 0; i < lopas.Length; i++)
            {
                if (!Char.IsLetterOrDigit(lopas[i]))
                {
                    isLetterOrDigit = false;
                    statusText.Text = "Неврное имя пользователя или пароль";
                    break;
                }
            }
            return isLetterOrDigit;
        }
        private void CloseEditTool()
        {
            inputPanel.Visible = false;
            ButtonVisibleTrue(addButton, delButton, editButton, extSearchbutton);
            editClick = false;
            index = -1;
        }
        private void ClearFields()
        {
            loginTB.Clear();
            passwTB.Clear();
            fullNameTB.Clear();
            adminRights.Checked = false;
        }
        private void selectAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < usersTable.Rows.Count; i++)
            {
                usersTable[checkBoxColumnIndex, i].Value = 1;
            }
            valueSelectedRecords.Text = usersTable.Rows.Count.ToString();
            TextToTB();
        }
        private void clearSelection_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < usersTable.Rows.Count; i++)
            {
                usersTable[checkBoxColumnIndex, i].Value = 0;
            }
            index = -1;
            valueSelectedRecords.Text = "0";
            if (editClick)
            {
                CloseEditTool();
            }
        }

    }
}
