using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access_text_files
{
    internal class Read_text_files
    {
        static void Main(string[] args)
        {//codes for reading from a text file
            string filePath = "D:\\C#_CONCEPTS_Screenshots\\c#_data_access_text_files\\C_sharp_data_access.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList(); 
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            //codes for writing in a text file
            lines.Add("This is the first line that is written in ide.");
            File.WriteAllLines(filePath, lines.ToArray());
            Console.ReadLine();

        }
    }
}
