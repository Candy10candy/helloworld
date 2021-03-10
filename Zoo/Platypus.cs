using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Platypus : Mammal, IWalk
    {
        public Platypus(double height, double weight, int age, string foodIEat, string name, bool eggs) : base(height, weight, age, foodIEat, name, eggs)
        {
        }

        public void Walk()
        {
            Console.WriteLine("*Platypus walking sounds*");
        }

        public int WalkSpeed()
        {

            return 100 - (int)Weight;
        }


    }
}
