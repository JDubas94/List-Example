using System;
using System.Collections.Generic;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dinosaurs = new List<string>();

            dinosaurs.Add("Pachycephalosaurus");
            dinosaurs.Add("Parasauralophus");
            dinosaurs.Add("Mamenchisaurus");
            dinosaurs.Add("Amargasaurus");
            dinosaurs.Add("Coelophysis");
            dinosaurs.Add("Oviraptor");

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            dinosaurs.Reverse();

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            dinosaurs.Reverse(1, 4);

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }
            Console.ReadLine();
        }
    }
}
