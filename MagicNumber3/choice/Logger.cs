using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MagicNumber3
{
    internal class Logger
    {
        public void SaveNumberToCSV(string firstNum)
        {
            string filePath = @"first_numbers_log.csv";

            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(firstNum);
            }
        }
    }
}