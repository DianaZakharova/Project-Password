using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_Password
{
    public class Generator
    {
        private static string UpperCase { get; } = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string Symbols { get; } = "~`'!@#$%^&*()_-+={}[]|\\:\";<,>.?/";
        private static string Numbers { get; } = "0123456789";
        private static string Similars { get; } = "il1Lo0O";
        private static string Ambiguous { get; } = "{}[]()/\\'\"`~,;:.<>";

        public static List<LoginPassword> LoadedPasswords { get; set; } = new List<LoginPassword>();

        public static int GetNextPasswordId()
        {
            if (LoadedPasswords.Count == 0)
            {
                return 0;
            }
            return LoadedPasswords.Max(x => x.Id) + 1;
        }
        public Generator()
        {
            LoadedPasswords = new DataBaseInteractions().GetAllLoadedPasswords();
            RndGen = new Random(Guid.NewGuid().GetHashCode());
        }
        public static string[] rockYouPasswords { get; set; }

        private Random RndGen { get; set; }
        public int Length { get; set; }
        public bool UseSymbols { get; set; }
        public bool UseNumbers { get; set; }
        public bool UseLowerCase { get; set; }
        public bool UseUpperCase { get; set; }
        public bool ExcludeSimilar { get; set; }
        public bool ExcludeAmbiguous { get; set; }
        public bool UseUnique { get; set; }
        private int RetryCount { get; set; }

        public string GeneratePassword()
        {
            List<char> charSearchList = new List<char>();
            if (UseUpperCase)
            {
                charSearchList.AddRange(UpperCase);
            }
            if (UseLowerCase)
            {
                charSearchList.AddRange(UpperCase.ToLower());
            }
            if (UseSymbols)
            {
                charSearchList.AddRange(Symbols);
                if (ExcludeAmbiguous)
                {
                    foreach (char excludeChar in Ambiguous)
                    {
                        charSearchList.Remove(excludeChar);
                    }
                }
            }
            if (UseNumbers)
            {
                charSearchList.AddRange(Numbers);
            }
            if (ExcludeSimilar)
            {
                foreach (char excludeChar in Similars)
                {
                    charSearchList.Remove(excludeChar);
                }
            }

            if (!UseUnique)
            {
                return GenerateFromList(charSearchList);
            }
            string generated;
            do
            {
                generated = GenerateFromList(charSearchList);
                RetryCount++;
            }
            while (rockYouPasswords.Contains(generated) && RetryCount != 10);
            if (RetryCount == 10)
            {
                return null;
            }
            RetryCount = 0;
            return generated;
        }

        private string GenerateFromList(List<char> collection)
        {
            StringBuilder passwordBuilder = new StringBuilder();
            for (int i = 0; i < Length; i++)
            {
                passwordBuilder.Append(collection[RndGen.Next(0, collection.Count())]);
            }
            return passwordBuilder.ToString();
        }

        public void SaveJson()
        {
            try
            {
                File.WriteAllText("generator.json", JsonConvert.SerializeObject(this));
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения найтроек генератора!", "Ошибка");
            }
        }
    }
}

