using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    internal class FileService
    {
        string filePath = "E:\\studijos\\Paskaitos\\paskaituKodai\\BE\\PassThroughControl\\Info.txt";

        public void Menu()
        {
            bool isAlive = true;
            while (isAlive)
            {
                Console.WriteLine("1. Read data");
                Console.WriteLine("2. Exit from program");
                var input = GetSelection();
                switch (input)
                {
                    case 1:
                        Read();
                        Console.WriteLine("\n " + " ");
                        break;
                    case 2:
                        isAlive = false;
                        Exit();
                        break;
                }
            }
        }
        public void WriteToFile()
        {
            Console.WriteLine("Enter your Name again to register your visit");
            var userInput = Console.ReadLine();
            DateTime time = DateTime.Now;
            if (File.Exists(filePath))
            {
                using (StreamWriter stream = File.AppendText(filePath))
                {
                    stream.WriteLine(userInput + " has visited " + time.ToString());
                    stream.Close();
                }
            }
        }

        private void Read()
        {
            string userInput;
            using (StreamReader stream = File.OpenText(filePath))
            {
                while ((userInput = stream.ReadLine()) != null)
                {
                    Console.WriteLine(userInput);
                }
                stream.Close();
            }
        }
        public int GetSelection()
        {
            bool isSuccess = Int32.TryParse(Console.ReadLine(), out int result);
            if (isSuccess)
            {
                return result;
            }
            Console.WriteLine("This doesnt do anything");
            return 0;
        }

        public void Exit()
        {
            System.Environment.Exit(1);
        }
    }
}
