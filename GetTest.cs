using System;
using System.Collections.Generic;
using System.IO;

namespace LuckyTickets
{
    static public class GetTest
    {
        static public void runTests(string catalog, func check)
        {
            // выбираем все файлы каталога, для каждого варианта запускаем нашу программу, и сравниваем ее с результатом
            var dictionaryIn = new Dictionary<string, string>();
            var dictionaryOut = new Dictionary<string, string>();
            string NumberTest;

            string[] files = Directory.GetFiles(catalog);
            foreach (string f in files)
            {

                if (f.Contains("test") && f.Contains("in"))
                {
                    NumberTest = f.Replace(".in", "");
                    NumberTest = NumberTest.Replace(catalog,"");


                    using (BinaryReader reader = new BinaryReader(File.OpenRead(f)))
                    {
                        string Content = File.ReadAllText(f);
                        dictionaryIn.Add(NumberTest, Content);
                    }
                }


                if (f.Contains("test") && f.Contains("out"))
                {
                    NumberTest = f.Replace(".out", "");
                    NumberTest = NumberTest.Replace(catalog, "");

                    using (BinaryReader reader = new BinaryReader(File.OpenRead(f)))
                    {
                        string Content = File.ReadAllText(f);
                        dictionaryOut.Add(NumberTest, Content);

                    }
                }
            }

            // далее, для каждого in ищем соответсвие out, если нашли - запускаем программу с входным параметром in
            foreach (var i in dictionaryIn)
            {
                if (dictionaryOut.ContainsKey(i.Key))
                {
                    if (long.Parse(dictionaryOut[i.Key]) == check(long.Parse(i.Value)))
                    { Console.WriteLine($"Выполнен  {i.Key}"); }
                    else 
                    { Console.WriteLine($"Ошибка в  {i.Key}"); } 
                }

            }


        }

        public delegate long func(long Value_in);
    }
}
