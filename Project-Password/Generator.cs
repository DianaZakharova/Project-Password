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
        private static string Similars { get; } = "|Iil1Lo0O";
        private static string Ambiguous { get; } = "{}[]()/\\'\"`~,;:.<>";
        public static List<LoginPassword> LoadedPasswords { get; set; } = new List<LoginPassword>();
        public static string[] rockYouPasswords { get; set; }
        private Random RndGen { get; set; }

        private int length;
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value < 6)
                {
                    length = 6;
                }
                else if (value > 100)
                {
                    length = 100;
                }
                else
                {
                    length = value;
                }
            }
        }
        public bool UseSymbols { get; set; }
        public bool UseNumbers { get; set; }
        public bool UseLowerCase { get; set; }
        public bool UseUpperCase { get; set; }
        public bool ExcludeSimilar { get; set; }
        public bool ExcludeAmbiguous { get; set; }
        public bool UseUnique { get; set; }
        private int RetryCount { get; set; }

        public Generator()
        {
            LoadedPasswords = new DataBaseInteractions().GetAllLoadedPasswords();
            RndGen = new Random(DateTime.Now.Millisecond);
        }

        public static int GetNextPasswordId()
        {
            if (LoadedPasswords.Count == 0)
            {
                return 0;
            }
            return LoadedPasswords.Max(x => x.Id) + 1;
        }

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
            if (ExcludeAmbiguous)
            {
                foreach (char excludeChar in Ambiguous)
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
            //Генерируем изначальный пароль
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < Length; i++)
            {
                builder.Append(collection[RndGen.Next(0, collection.Count())]);
            }
            string analyzeString = builder.ToString();
            //Определяем разрешённые для вставки символы
            string permittedUpperCase = UpperCase;
            string permittedLowerCase = UpperCase.ToLower();
            string permittedNumbers = Numbers;
            string permittedSymbols = Symbols;
            if (ExcludeSimilar)
            {
                foreach (char excludeChar in Similars)
                {
                    permittedUpperCase = permittedUpperCase.Replace(excludeChar.ToString(), "");
                    permittedLowerCase = permittedLowerCase.Replace(excludeChar.ToString(), "");
                    permittedNumbers = permittedNumbers.Replace(excludeChar.ToString(), "");
                }
            }
            if (ExcludeAmbiguous)
            {
                foreach (char excludeChar in Ambiguous)
                {
                    permittedSymbols = permittedSymbols.Replace(excludeChar.ToString(), "");
                }
            }
            //Определяем, надо ли производить дополнительные изменения
            bool upperCaseNotUsed = UseUpperCase && !builder.ToString().Any(x => permittedUpperCase.Contains(x));
            bool lowerCaseNotUsed = UseLowerCase && !builder.ToString().Any(x => permittedLowerCase.Contains(x));
            bool numbersNotUsed = UseNumbers && !builder.ToString().Any(x => permittedNumbers.Contains(x));
            bool symbolsNotUsed = UseSymbols && !builder.ToString().Any(x => permittedSymbols.Contains(x));
            if (upperCaseNotUsed || lowerCaseNotUsed || numbersNotUsed || symbolsNotUsed)
            {
                //Определяем список позиций в строке, заместо которых будем вставлять
                bool upperFound = false;
                bool lowerFound = false;
                bool numberFound = false;
                bool symbolFound = false;
                List<int> possiblePositions = new List<int>();
                for (int i = 0; i
                < builder.Length; i++)
                {
                    if (!upperFound && UseUpperCase && permittedUpperCase.Contains(analyzeString[i]))
                    {
                        upperFound = true;
                        continue;
                    }
                    if (!lowerFound && UseLowerCase && permittedLowerCase.Contains(analyzeString[i]))
                    {
                        lowerFound = true;
                        continue;
                    }
                    if (!numberFound && UseNumbers && permittedNumbers.Contains(analyzeString[i]))
                    {
                        numberFound = true;
                        continue;
                    }
                    if (!symbolFound && UseSymbols && permittedSymbols.Contains(analyzeString[i]))
                    {
                        symbolFound = true;
                        continue;
                    }
                    possiblePositions.Add(i);
                }

                int replacePosition = 0; //Переменная для замены позиций, которую далее будем использовать
                                         //Если надо вставить Верхний регистр
                if (upperCaseNotUsed)
                {
                    replacePosition = possiblePositions[RndGen.Next(0, possiblePositions.Count)];
                    possiblePositions.Remove(replacePosition);
                    builder.Remove(replacePosition, 1);
                    builder.Insert(replacePosition, permittedUpperCase[RndGen.Next(0, permittedLowerCase.Length)]);
                }
                //Если надо вставить нижний регистр
                if (lowerCaseNotUsed)
                {
                    replacePosition = possiblePositions[RndGen.Next(0, possiblePositions.Count)];
                    possiblePositions.Remove(replacePosition);
                    builder.Remove(replacePosition, 1);
                    builder.Insert(replacePosition, permittedLowerCase[RndGen.Next(0, permittedLowerCase.Length)]);
                }
                //Если надо вставить цифру
                if (numbersNotUsed)
                {
                    replacePosition = possiblePositions[RndGen.Next(0, possiblePositions.Count)];
                    possiblePositions.Remove(replacePosition);
                    builder.Remove(replacePosition, 1);
                    builder.Insert(replacePosition, permittedNumbers[RndGen.Next(0, permittedNumbers.Length)]);
                }
                //Если надо вставить символ
                if (symbolsNotUsed)
                {
                    replacePosition = possiblePositions[RndGen.Next(0, possiblePositions.Count)];
                    possiblePositions.Remove(replacePosition);
                    builder.Remove(replacePosition, 1);
                    builder.Insert(replacePosition, permittedSymbols[RndGen.Next(0, permittedSymbols.Length)]);
                }
            }
            return builder.ToString();
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


