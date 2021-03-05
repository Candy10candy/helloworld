using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Mammal : Animal
    {
        private bool eggs;
        public bool Eggs
        {
            get
            { return eggs; }
            set
            { eggs = value; }

        }


        public Mammal(double height, double weight, int age, string foodIEat, string name, bool eggs) : base(height, weight, age, foodIEat, name)
        {
            this.eggs = Eggs;

        }

        public string produceMilk()
        { return "As a mammal, " + Name + "s can produce milk."; }

        public string layEggs()
        {
            if (Eggs == true)
            { return Name + "s lay eggs"; }
            else
            { return Name + "s lay eggs"; }

            }

    }
}
