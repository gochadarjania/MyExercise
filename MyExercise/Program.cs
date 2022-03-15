using System;
using System.Collections.Generic;

namespace MyExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Services services = new Services();

            List<int> numbers = new List<int> { 2, 3, 4, 5, 6, 23 };

            string[] names = new string[] { "Gocha", "Gio", "Levani" };

            //services.Writer(names);

            List<int> list = services.RemoveFromList(numbers, 23); //Test Remove Element from List

            services.Writer(list);

            

        }

    }
}
