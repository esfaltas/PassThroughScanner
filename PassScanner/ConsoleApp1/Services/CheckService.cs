using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    internal class CheckService
    {
        public void Check() 
        {
            var fileService = new FileService();
            var canPass = new List<string> { "Vardas1", "Vardas2", "Vardas3" };
            var Visitor1 = canPass.ElementAt(0);
            var Visitor2 = canPass.ElementAt(1);
            var Visitor3 = canPass.ElementAt(2);

            Console.WriteLine("Enter your name: ");
            var userInput = Convert.ToString(Console.ReadLine());

            if (userInput == Visitor1 || userInput == Visitor2 || userInput == Visitor3)
            {
                Console.WriteLine($"{userInput} has an access");
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine($"{userInput} does not have an access");
                fileService.Exit();
            }

            fileService.WriteToFile();
            fileService.Menu();
        }
    }
}
