﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ssss;

namespace ssss
{
    internal class Animal
    {
            
        public string food;
        public string location;
        

            public Animal(string food, string location)
            {

                this.food = food;
                this.location = location;

            }


            public void makeNoise()
            {
                Console.WriteLine("шумит");
            }

            public void eat()
            {
            Console.WriteLine("ест");
            }

            public void sleep()
            {
            Console.WriteLine("спит");
            }
       
    }
}
