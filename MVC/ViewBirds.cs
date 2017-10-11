using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class ViewBirds : View
    {
        public void DisplayAnimals(List<string> animals)
        {
            foreach (string bird in animals)
            {
                Console.WriteLine("Hello " + bird);
            }
        }

        public void PrintAnimal(string s)
        {
            Console.WriteLine("Hello " + s);
        }
    }
}
