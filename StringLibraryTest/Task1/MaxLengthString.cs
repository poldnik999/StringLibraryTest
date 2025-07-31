using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringLibraryTest.Task1
{
    internal class MaxLengthString
    {
        public string GetMaxString(string path)
        {
            List<string> words = new List<string>(GetFileWords(path));
            
            List<string> invWords = ListInvalidWords(path);
            var result = words.Except(invWords);
            return result.OrderByDescending(word => word.Length).FirstOrDefault();
        }
        private string[] GetFileWords(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string content = reader.ReadToEnd();
                string[] words = content.Split(' ');

                if (string.IsNullOrEmpty(content))
                    Console.WriteLine("Файл пустой. Обработка невозможна."); //Можно было бросить Exception, но тогда вторая задача не работает)
                return words;
            }

        }
        public List<string> ListInvalidWords(string path)
        {
            List<string> invWords = new List<string>();
            string[] words = GetFileWords(path);
            for(int i = 0;i < words.Length; i++)
            {
                if (IsInvalidWord(words[i]))
                    invWords.Add(words[i]);
            }
            return invWords;
        }

        private static bool IsInvalidWord(string word)
        {
            return Regex.IsMatch(word, @"[^a-zа-я\s]", RegexOptions.IgnoreCase);
        }
    }
}
