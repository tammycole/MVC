using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
	class Controller
	{
		Mammal m;
		ViewMammals mv;
		Bird b;
		ViewBirds bv;

		public Controller()
		{
			mv = new ViewMammals();
			m = new Mammal();
			b = new Bird();
			bv = new ViewBirds();
		}

		public void DisplayAnimals()
		{
			mv.DisplayAnimals(m.GetAllAnimals());
		}
	}


}
