using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ConsoleApp1;

namespace ConsoleApp1.Services
{
    internal class VisitorsRepository
    {
        public void VisitorsList()
        {
            var humans = new List<Human>()
            {
                new Human() { Id = 1, FirstName = "Vardas1", LastName = "Pavarde1" },
                new Human() { Id = 2, FirstName = "Vardas2", LastName = "Pavarde2" },
                new Human() { Id = 3, FirstName = "Vardas3", LastName = "Pavarde3" },
            };
        }
    }
}
