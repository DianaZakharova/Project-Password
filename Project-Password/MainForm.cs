using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Project_Password
{
    public partial class MainForm : Form
    {
        private Generator Generator { get; set; }
        private DataBaseInteractions dataBaseInteractions = new DataBaseInteractions();
        public MainForm(Generator generator)
        {
            Generator = generator;
            InitializeComponent();
        }

        private void OnSymbolsChanged(object sender, EventArgs e)
        {
            if (!(symbolsCheckBox.Checked || numbersCheckBox.Checked || lowerCaseCheckBox.Checked || upperCaseCheckBox.Checked))
            {
                MessageBox.Show("Выберите хотя бы одну группу символов для генерации!", "Ошибка");
                symbolsCheckBox.Checked = true;
                return;
            }
            Generator.UseSymbols = symbolsCheckBox.Checked;
        }

        private void OnNumbersChanged(object sender, EventArgs e)
        {
            if (!(symbolsCheckBox.Checked || numbersCheckBox.Checked || lowerCaseCheckBox.Checked || upperCaseCheckBox.Checked))
            {
                MessageBox.Show("Выберите хотя бы одну группу символов для генерации!", "Ошибка");
                numbersCheckBox.Checked = true;
                return;
            }
            Generator.UseNumbers = numbersCheckBox.Checked;
        }

        private void OnLowerChanged(object sender, EventArgs e)
        {
            if (!(symbolsCheckBox.Checked || numbersCheckBox.Checked || lowerCaseCheckBox.Checked || upperCaseCheckBox.Checked))
            {
                MessageBox.Show("Выберите хотя бы одну группу символов для генерации!", "Ошибка");
                lowerCaseCheckBox.Checked = true;
                return;
            }
            Generator.UseLowerCase = lowerCaseCheckBox.Checked;
        }

        private void OnUpperChanged(object sender, EventArgs e)
        {
            if (!(symbolsCheckBox.Checked || numbersCheckBox.Checked || lowerCaseCheckBox.Checked || upperCaseCheckBox.Checked))
            {
                MessageBox.Show("Выберите хотя бы одну группу символов для генерации!", "Ошибка");
                upperCaseCheckBox.Checked = true;
                return;
            }
            Generator.UseUpperCase = upperCaseCheckBox.Checked;
        }

        private void OnSimilarChanged(object sender, EventArgs e)
        {
            Generator.ExcludeSimilar = upperCaseCheckBox.Checked;
        }

        private void OnAmbiguousChanged(object sender, EventArgs e)
        {
            Generator.ExcludeAmbiguous = upperCaseCheckBox.Checked;
        }

        private void uniqueCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Generator.UseUnique = uniqueCheckBox.Checked;
        }

        private void OnGenerateClick(object sender, EventArgs e)
        {
            if (!(symbolsCheckBox.Checked || numbersCheckBox.Checked || lowerCaseCheckBox.Checked || upperCaseCheckBox.Checked))
            {
                MessageBox.Show("Выберите хотя бы одну группу символов для генерации!", "Ошибка");
                symbolsCheckBox.Checked = true;
                numbersCheckBox.Checked = true;
                lowerCaseCheckBox.Checked = true;
                return;
            }
            string generated = Generator.GeneratePassword();
            Generator.SaveJson();
            if (generated == null)
            {
                MessageBox.Show("После 10 попыток генерации не был найден уникальный пароль среди из текущего набора символов.", "Ошибка");
                return;
            }
            generatedTextBox.Text = generated;
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            lengthUpDown.Value = Generator.Length;
            symbolsCheckBox.Checked = Generator.UseSymbols;
            numbersCheckBox.Checked = Generator.UseNumbers;
            upperCaseCheckBox.Checked = Generator.UseUpperCase;
            lowerCaseCheckBox.Checked = Generator.UseLowerCase;
            similarCheckBox.Checked = Generator.ExcludeSimilar;
            ambiguousCheckBox.Checked = Generator.ExcludeAmbiguous;
            uniqueCheckBox.Checked = Generator.UseUnique;
        }

        private void OnLengthChanged(object sender, EventArgs e)
        {
            Generator.Length = (int)lengthUpDown.Value;
        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            if (generatedTextBox.Text.Length == 0)
            {
                MessageBox.Show("Для начала, снегерируйте пароль!", "Ошибка");
                return;
            }
            if (loginTextBox.Text.Length == 0)
            {
                MessageBox.Show("Введите логин, если хотите сохранить пароль!", "Ошибка");
                return;
            }
            if (Generator.LoadedPasswords.Where(x => x.Login.Equals(loginTextBox.Text)).Any(x => x.Decrypt().Equals(generatedTextBox.Text)))
            {
                MessageBox.Show("Такой пароль уже сохранён при этом логине!", "Ошибка");
                return;
            }
            string encodedString = EncryptString(generatedTextBox.Text, loginTextBox.Text);
            LoginPassword password = new LoginPassword(Generator.GetNextPasswordId(), loginTextBox.Text, encodedString);
            Generator.LoadedPasswords.Add(password);
            dataBaseInteractions.AddPasswordToDatabase(password);
            MessageBox.Show($"Ваш пароль был успешно сохранён на логин: {loginTextBox.Text}", "Сохранено!");
        }

        public static string EncryptString(string text, string keyString)
        {
            var key = new SHA256Managed().ComputeHash(Encoding.Default.GetBytes(keyString));

            using (var aesAlg = Aes.Create())
            {
                using (var encryptor = aesAlg.CreateEncryptor(key, aesAlg.IV))
                {
                    using (var msEncrypt = new MemoryStream())
                    {
                        using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        using (var swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(text);
                        }

                        var iv = aesAlg.IV;

                        var decryptedContent = msEncrypt.ToArray();

                        var result = new byte[iv.Length + decryptedContent.Length];

                        Buffer.BlockCopy(iv, 0, result, 0, iv.Length);
                        Buffer.BlockCopy(decryptedContent, 0, result, iv.Length, decryptedContent.Length);

                        return Convert.ToBase64String(result);
                    }
                }
            }
        }
    }
}

