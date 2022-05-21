using Newtonsoft.Json;
using NLog;
using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Project_Password
{
    public partial class Load : Form
    {
        private int timerCount;
        private Generator Generator { get; set; }
        private Logger logger;
        public Load()
        {
            logger = LogManager.GetCurrentClassLogger();
            logger.Info("Программа запущена");
            InitializeComponent();
            timerCount = 0;
            loadingTimer.Start(); //запустили таймер
            loadWorker.RunWorkerAsync();
        }

        private void Loading(object sender, DoWorkEventArgs e)
        {
            logger.Trace("Началась загрузка...");
            if (File.Exists("generator.json"))
            {
                try
                {
                    Generator = JsonConvert.DeserializeObject<Generator>(File.ReadAllText("generator.json"));
                    logger.Trace("Генератор успешно загружен!");
                }
                catch (Exception ecxeptionFirst)
                {
                    logger.Error($"Ошибка чтения сохранения генератора: {ecxeptionFirst}");
                    Generator = new Generator();
                    Generator.UseLowerCase = true;
                    Generator.UseNumbers = true;
                    Generator.UseSymbols = true;
                    Generator.Length = 16;
                    logger.Trace("Создан новый объект генератора!");
                    try
                    {
                        File.WriteAllText("generator.json", JsonConvert.SerializeObject(Generator));
                        logger.Trace("Новый файл генератора создан!");
                    }
                    catch (Exception ecxeptionSecond)
                    {
                        logger.Error($"Ошибка записи нового сохранения генератора: {ecxeptionSecond}");
                        MessageBox.Show("Отсутствует файл найтроек генератора. Ошибка при создании нового.", "Ошибка");
                    }
                }
            }
            else
            {
                logger.Warn("Файл сохранения генератора не был найден!");
                Generator = new Generator();
                Generator.UseLowerCase = true;
                Generator.UseNumbers = true;
                Generator.UseSymbols = true;
                Generator.Length = 16;
                logger.Trace("Создан новый объект генератора!");
                try
                {
                    File.WriteAllText("generator.json", JsonConvert.SerializeObject(Generator));
                    logger.Trace("Новый файл генератора создан!");
                }
                catch (Exception exception)
                {
                    logger.Error($"Ошибка записи нового сохранения генератора: {exception}");
                    MessageBox.Show("Отсутствует файл найтроек генератора. Ошибка при создании нового.", "Ошибка");
                }
            }
            if (File.Exists("rockyou.txt"))
            {
                try
                {
                    Generator.rockYouPasswords = File.ReadAllLines("rockyou.txt");
                    logger.Trace("Распропростанённые пароли были успешно загружены!");
                }
                catch
                {
                    MessageBox.Show("Ошибка чтения пароля", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Ошибка загрузки файла паролей", "Ошибка");
            }
            Thread.Sleep(1000); //Чтобы видно было
            logger.Trace("Загрузка закончена!");
        }

        #region Moving
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void OnMoveMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void OnLoadingTimerTick(object sender, EventArgs e)
        {
            timerCount++;
            switch (timerCount % 4)
            {
                case 0:
                    loadingLabel.Text = "Загрузка";
                    break;
                case 1:
                    loadingLabel.Text = "Загрузка.";
                    break;
                case 2:
                    loadingLabel.Text = "Загрузка..";
                    break;
                case 3:
                    loadingLabel.Text = "Загрузка...";
                    break;
            }
        }

        private void OnLoadComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            Hide();
            loadingTimer.Stop();
            new MainForm(Generator).ShowDialog();
            Close();
        }
    }
}