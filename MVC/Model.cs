﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    interface Animal
    {

        string GetAnimal(int index);

        List<string> GetAllAnimals();
       
    }
}
