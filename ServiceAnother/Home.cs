using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace ServiceAnother
{
    public partial class Home : Form
    {
        string userName;
        int ifAdmin;

        SQLiteConnection connection;
        SQLiteCommand cmd;
        public Home()
        {
            InitializeComponent();
        }
        public Home(string _userName, int _ifAdmin, SQLiteConnection firstFormConnection)
        {
            InitializeComponent();

            connection = firstFormConnection;
            userName = _userName;
            ifAdmin = _ifAdmin;
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE Users SET ifSignIn = '0' WHERE UserName = '{userName}'";
            cmd = new SQLiteCommand(query, connection);

            cmd.ExecuteNonQuery();
            Hide();
            LogInForm logInForm = new LogInForm(connection);
            logInForm.Show();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            string selectFullName = $"SELECT FullName FROM Users WHERE UserName = '{userName}'";
            cmd = new SQLiteCommand(selectFullName, connection);

            SQLiteDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    fullNameLabel.Text = dataReader[0].ToString();
                }
            }
            userNamelabel.Text = userName;

            if (ifAdmin == 1)
            {
                usersButton.Visible = true;
                userPB.Image = Properties.Resources.admin520;
            }
            else
            {
                usersButton.Visible = false;
                userPB.Image = Properties.Resources.simpleuser520;
                Height -= usersButton.Height;
            }
        }
       
        private void clientsButton_Click(object sender, EventArgs e)
        {
            FormClientsTable formClientsTable = new FormClientsTable(this, userName, ifAdmin, connection);
            Hide();
            formClientsTable.Show();
        }
        private void serviceButton_Click(object sender, EventArgs e)
        {
            FormServiceTable formServiceTable = new FormServiceTable(connection, this, ifAdmin);
            Hide();
            formServiceTable.Show();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            if (Directory.Exists("tmp"))
            {
                Directory.Delete("tmp", true);
            }
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm(connection, this);
            Hide();
            usersForm.Show();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            AboutProgForm aboutProgForm = new AboutProgForm();
            aboutProgForm.ShowDialog();
        }
    }
    
}
