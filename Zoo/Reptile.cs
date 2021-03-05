using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Reptile : Animal
    {

        private int eggs;
        public int Eggs
        {
            get
            { return eggs; }
            set
            { eggs = value; }

        }
        public Reptile(double height, double weight, int age, string foodIEat, string name, int eggs) : base (height, weight ,age, foodIEat, name)
        {
            this.eggs = Eggs;
         
        }

        public string layEgg()
        { return "As a reptile, " + Name + "s lay " + Eggs + " eggs."; }

        public string molt()
        { return "As a reptile, " + Name + "s molt."; }

    }
}
