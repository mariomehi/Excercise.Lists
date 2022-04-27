using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Excercise.Lists.Models;
using System.Linq;

namespace Excercise.Lists.Utils
{
    internal class OriginalTextFileProcessor
    {
        public static void ComposeFile(string dir, string fileName, List<People> list)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            try
            {
                if (!File.Exists(fileName))
                {
                    File.Create(fileName);
                }

                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine("Id, Name, IsActive");
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
            // APPEND PEOPLE ON FILE
            Console.WriteLine("\nSto scrivendo la lista sul file.\n");
            foreach (People people in list)
            {
                string str = "" + people.Id + ", " + people.Name + ", " + people.IsActive.ToString() + "\n";
                File.AppendAllText(fileName, str, Encoding.UTF8);
            }
        }

            public static void ReadFromFile(string fileName) {
                Console.WriteLine("Leggo da file csv");
                List<People> newlist = File.ReadAllLines(fileName)
                                   .Skip(1)
                                   .Select(v => People.FromCSV(v))
                                   .ToList();

                foreach (People pi in newlist)
                {
                    Console.Write("\t {0} {1} {2}\n", pi.Id, pi.Name, pi.IsActive);
                }
            }

    }
}
