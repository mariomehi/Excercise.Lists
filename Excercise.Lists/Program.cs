using System;
using System.Collections.Generic;
using System.IO;

namespace Excercise.Lists
{
    internal class Program
    {
        public static List<Models.People> list;
        static void Main(string[] args)
        {
            var path = Directory.GetCurrentDirectory();
            var nomec = "Utils";
            string dir = $"{path}{Path.DirectorySeparatorChar}{nomec}";

            string nfile = "people.csv";
            string fileName = Path.Combine(dir, nfile);

            MockData();
            Utils.OriginalTextFileProcessor.ComposeFile(dir, fileName, list);
            Utils.OriginalTextFileProcessor.ReadFromFile(fileName);
        }
        public static void MockData()
        {
            list = new List<Models.People>()
            {
                new Models.People() { Id = 1, Name ="AAA", IsActive=true },
                new Models.People() { Id = 2, Name ="BBB", IsActive=false },
                new Models.People() { Id = 3, Name ="CCC", IsActive=true },
                new Models.People() { Id = 4, Name ="DDD", IsActive=false },
                new Models.People() { Id = 5, Name ="EEE", IsActive=true }
            };

            Console.WriteLine("Lista Inizializzata: ");
            foreach (var pi in list)
            {
                Console.Write("\t {0} {1} {2} \n", pi.Id, pi.Name,pi.IsActive);
            }
        }
    }
}
