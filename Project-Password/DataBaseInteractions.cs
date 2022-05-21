using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Project_Password
{
    internal class DataBaseInteractions
    {
        SQLiteConnection conn = new SQLiteConnection(@"Data Source=.\..\..\Resources\db.db");
        public void AddPasswordToDatabase(LoginPassword password)
        {
            try
            {
                conn.Open();
                using (SQLiteCommand command = conn.CreateCommand())
                {
                    command.CommandText = $"INSERT INTO SavePassword(login, password) VALUES ('{password.Login}', '{password.Password}')";
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}. Не получилось выполнить сохранение пароля в базу данных");
            }
        }
        public List<LoginPassword> GetAllLoadedPasswords()
        {
            List<LoginPassword> passwords = new List<LoginPassword>();
            try
            {
                conn.Open();
                var read = conn.CreateCommand(); //хранится ссылка на команду
                read.CommandText = "SELECT * FROM SavePassword";
                using (var reader = read.ExecuteReader()) //выполнение команды и возврат элементов с бд в зависимости от запроса
                {
                    while (reader.Read())
                    {
                        passwords.Add(new LoginPassword(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                    }
                    reader.Close();
                }
            }
            catch (SQLiteException e)
            {
                Console.WriteLine("Неверно указан путь до БД: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            conn.Close();
            return passwords;
        }

    }
}
