﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExample
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Person[] peopleArray = new Person[3]
             {
               new Person("John", "Smith"),
               new Person("Jim", "Johnson"),
               new Person("Sue", "Rabon"),
            };
			//peopleList
            People peopleList = new People(peopleArray);
            foreach (Person p in peopleList)
                Console.WriteLine(p.firstName + "   " + p.lastName);

        }
    }
}
