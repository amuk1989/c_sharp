using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    class Enter
    {
        public string result;
        public Enter(string question) 
        {

            Console.Write(question);
            result = Console.ReadLine();

        }
        
    }
}
