using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ServiceAnother
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string connectionString = "DataSource=DB.db; Version=3";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();

            string query = $"SELECT ifAdmin, UserName, ifSignIn FROM Users WHERE ifSignIn = '1'";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);

            SQLiteDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                string userName = "";
                int ifAdmin = 0;
                while (dataReader.Read())
                {
                    ifAdmin = Convert.ToInt32(dataReader[0].ToString());
                    userName = dataReader[1].ToString();
                }
                Application.Run(new Home(userName, ifAdmin, connection));
            }
            else
            {
                Application.Run(new LogInForm(connection));
            }
        }
    }
}
