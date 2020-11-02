using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace ServiceAnother
{
    public partial class LogInForm : Form
    {
        
        SQLiteConnection connection;
        SQLiteDataReader dataReader;
        SQLiteCommand cmd;

        int ifAdmin = 0;

        public LogInForm()
        {
            InitializeComponent();
        }
        public LogInForm(SQLiteConnection _connection)
        {
            InitializeComponent();
            connection = _connection;
        }
        private void enterButton_Click(object sender, EventArgs e)///////////Проверка существования пользователя, правильность введнного пароль, и переход на следующую форму
        {
            errorLabel.Visible = false;
            if (nameTB.Text == "" || passwordTB.Text == "")
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Введите имя пользователя\nи пароль";
            }
            else
            {
                string query = $"SELECT * FROM Users WHERE UserName = '{nameTB.Text}'";
                cmd = new SQLiteCommand(query, connection);
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Close();

                    query = $"SELECT * FROM Users WHERE UserName = '{nameTB.Text}' AND Password = '{passwordTB.Text}'";
                    cmd = new SQLiteCommand(query, connection);
                    dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        dataReader.Close();

                        query = $"SELECT ifAdmin FROM Users WHERE UserName = '{nameTB.Text}' AND Password = '{passwordTB.Text}'";
                        cmd = new SQLiteCommand(query, connection);
                        dataReader = cmd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            ifAdmin = Convert.ToInt32(dataReader[0].ToString());
                        }

                        query = $"UPDATE Users SET ifSignIn = '1' WHERE UserName = '{nameTB.Text}'";
                        cmd = new SQLiteCommand(query, connection);
                        cmd.ExecuteNonQuery();

                        Home home = new Home(nameTB.Text, ifAdmin, connection);
                        ClearTextBox();

                        Hide();
                        home.Show();
                    }
                    else
                    {
                        errorLabel.Visible = true;
                        errorLabel.Text = "Неверный пароль";
                    }
                }
                else
                {
                    errorLabel.Visible = true;
                    errorLabel.Text = "Несуществующий пользователь";
                }
                ClearTextBox();
            }
        }
        private void nameTB_Click(object sender, EventArgs e)
        {
            if (errorLabel.Visible)
            {
                errorLabel.Visible = false;
            }
        }
        public void ClearTextBox()
        {
            nameTB.Clear();
            passwordTB.Clear();
        }
        private void LogInForm_MouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }
        private void LogInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            if (Directory.Exists("tmp"))
            {
                Directory.Delete("tmp", true);
            }
        }
    }
}
