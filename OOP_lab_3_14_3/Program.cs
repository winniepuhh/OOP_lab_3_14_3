using System;
using System.IO;

namespace OOP_lab_3_14_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("input.txt");

            StreamWriter newFile = File.CreateText("output.txt");

            newFile.Write(file.ReadToEnd().Length);

            newFile.Close();
        }
    }
}
