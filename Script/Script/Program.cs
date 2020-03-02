using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDatabaseScript
{
    class Program
    {
        static void Main(string[] args)
        {

            string filePath = @"C:\Users\Csaba\Desktop\okj\c#\Script\Script\bin\Debug\netcoreapp3.1\myfile.txt";

            try
            {
                // Open the stream and read it back.
                using (StreamReader sr = File.OpenText(filePath))
                {
                    string s = "";
                    bool isAlbum = false;
                    bool isInitial = true;
                    while ((s = sr.ReadLine()) != null)
                    {
                        if (s.Equals("[albums]"))
                        {
                            isAlbum = true;
                            s = sr.ReadLine();
                        }
                        else if (s.Equals("[tracks]"))
                        {
                            isAlbum = false;
                            s = sr.ReadLine();
                        }

                        SqlPopulationScriptMaker(isInitial, isAlbum, s);
                        isInitial = false;
                    }
                    Console.WriteLine("A script elkészült. \n Press any key to exit");
                    Console.Read();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public static void SqlPopulationScriptMaker(bool isInitial, bool isAlbum, string line)
        {
            try
            {

                using (FileStream sw = new FileStream(@"C:\Users\Csaba\Desktop\okj\c#\adat.sql", FileMode.Append))
                {
                    if (isInitial)
                    {
                        byte[] firstLine = new UTF8Encoding(true).GetBytes("USE music\n");
                        sw.Write(firstLine, 0, firstLine.Length);
                        byte[] secondLine = new UTF8Encoding(true).GetBytes("GO\n");
                        sw.Write(secondLine, 0, secondLine.Length); 
                        byte[] lineInBytes = new UTF8Encoding(true).GetBytes(DecideTable(isAlbum, line));
                        sw.Write(lineInBytes, 0, lineInBytes.Length);

                    }
                    else
                    {
                        byte[] lineInBytes = new UTF8Encoding(true).GetBytes(DecideTable(isAlbum, line));
                        sw.Write(lineInBytes, 0, lineInBytes.Length);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string DecideTable(bool isAlbum, string line)
        {
            if (isAlbum)
            {
                return "INSERT INTO Album VALUES ('" + String.Join("','", line.Split(';')) + "');\n";
            }
            else
            {
                return "INSERT INTO Tracks VALUES ('" + String.Join("','", line.Split(';')) + "');\n";
            }
        }
    }
}
