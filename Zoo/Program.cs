using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Animal> listOfAnimals = new List<Animal>();

            while (true)
            {

                Console.WriteLine("Would you like to make a reptile or a mammal?");

                string animalType = Console.ReadLine();

                Console.WriteLine("What is its height?");

                double animalHeight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What is its weight?");

                double animalWeight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("How old is it?");

                int animalAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What does it eat?");

                string animalFood = Console.ReadLine();

                Console.WriteLine("What is its name?");

                string animalName = Console.ReadLine();


                if (animalType.ToLower() == "reptile")
                {
                    Console.WriteLine("How many eggs does it lay?");

                    int reptileEggs = Convert.ToInt32(Console.ReadLine());
                    Reptile reptile = new Reptile(animalHeight, animalWeight, animalAge, animalFood, animalName, reptileEggs);

                    listOfAnimals.Add(reptile);
                }

                if (animalType.ToLower() == "mammal")
                {
                    

                    Console.WriteLine("Does it lay eggs? Enter yes if it does, or anything else if not.");

                    bool mammalEggs = false;

                    if (Console.ReadLine().ToLower() == "yes")
                    {
                        mammalEggs = true;
                    }

                    Console.WriteLine("Make a platypus?");
                    string platypusResponse = Console.ReadLine();

                    if (platypusResponse.ToLower() == "yes")
                    {
                        Platypus platypus = new Platypus(animalHeight, animalWeight, animalAge, animalFood, animalName, mammalEggs);
                        listOfAnimals.Add(platypus);
                    }
                    else
                    {
                        Mammal mammal = new Mammal(animalHeight, animalWeight, animalAge, animalFood, animalName, mammalEggs);
                        listOfAnimals.Add(mammal);
                    }
                }

                Console.WriteLine("Done? Type 'stop'");
                if(Console.ReadLine() == "stop")
                { break; }

            }

            foreach (Animal animal in listOfAnimals)
            {
                Console.WriteLine(animal.Name);
                if(typeof(Reptile) == animal.GetType())
                {
                    Console.WriteLine(((Reptile)animal).Eggs);
                }

                if (animal is IWalk)
                {
                    ((IWalk)animal).Walk();
                }

            }

            Console.ReadLine();
        }
    }
}
