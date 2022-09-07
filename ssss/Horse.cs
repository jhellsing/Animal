using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ssss
{
    internal class Horse:Animal
    {
        string oret;
        public Horse(string oret, string food, string location): base (food, location)
        {

            this.oret = oret;
        }

       
    
    public void makeNoise()
        {
            Console.WriteLine("привет");
        }

  
    public void eat()
        {
            Console.WriteLine("ест");
        }
    }
}
