using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access_text_files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\C#_CONCEPTS_Screenshots\\c#_data_access_text_files\\C_sharp_data_access.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList(); 
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();

        }
    }
}
