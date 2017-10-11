using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller mv = new Controller();
            Controller m = new Controller();
            Controller bv = new Controller();
            Controller b = new Controller();
            mv.DisplayAnimals();
        }
    }
}
