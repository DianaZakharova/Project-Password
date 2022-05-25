using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Project_Password
{
    internal class DataBaseInteractions
    {
        private static string path = @"Data Source=db.db;Version=3;";

        public void AddPasswordToDatabase(LoginPassword password)
        {
            using (SQLiteConnection connection = new SQLiteConnection(path))
            {
                connection.Open();
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    command.CommandText = $"INSERT INTO SavePassword(id, login, password) VALUES ({password.Id}, '{password.Login}', '{password.Password}');";
                    command.ExecuteNonQuery();
                }
            }
        }


        public List<LoginPassword> GetAllLoadedPasswords()
        {
            List<LoginPassword> passwords = new List<LoginPassword>();
            using (SQLiteConnection connection = new SQLiteConnection(path))
            {
                connection.Open();
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM SavePassword";
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                passwords.Add(new LoginPassword(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                            }
                        }
                    }
                }
            }
            return passwords;
        }
    }

}

