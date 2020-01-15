using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    
    
    class person
    {
        public string name;

        Enter _name = new Enter("Ваше имя: ");
        name = _name.result;


        Enter _last_name = new Enter("Ваша фамилия: ");
        Enter _age = new Enter("Ваш возраст: ");
        Enter _height = new Enter("Ваш рост: ");
        Enter _weight = new Enter("Ваш вес: ");
               
    }
}
