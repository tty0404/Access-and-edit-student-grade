using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_3
{
    internal class FileManager
    {
        public string filePath = @"studentlist.txt";
        public FileManager()
        {
        }
        public FileManager(string filePath)
        {
            this.filePath = filePath;
        }

        public void saveOrUpdateDataToFile(string dataToBeSave)
        {
            File.AppendAllText(filePath, dataToBeSave + Environment.NewLine);
        }
        public int getNumberOfStudentsInFile()
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader textIn = new StreamReader(fs);
            Console.WriteLine("Reading from file ....");
            string[] data = textIn.ReadToEnd().Split("\n");
            // Remove empty strings and white spaces
            data = data.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            data = data.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
            fs.Close();
            fs.Dispose();
            return data.Length;
        }

        // Reads student data from file
        public string[] readStudentDataFromFile()
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader textIn = new StreamReader(fs);
            Console.WriteLine("Reading from file ....");
            string data = textIn.ReadToEnd();
            string[] splitByBackslash = data.Split("\r");
            splitByBackslash = splitByBackslash.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            splitByBackslash = splitByBackslash.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
            fs.Close();
            fs.Dispose();
            return splitByBackslash;
        }


    }
}
