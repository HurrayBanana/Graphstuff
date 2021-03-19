using System;
using System.Collections.Generic;
using System.Text;

namespace Graphstuff
{
    class Dog : Animal
    {
        private string breed;

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }
        public Dog(string name, float weight)
            :base(name, weight) 
        {
        }

        public void Bark(float loudness)
        {

        }

        public void Jump(float height)
        {

        }
        public void Sleep(float time)
        {

        }
        public void Eat()
        {

        }
        public void Drink()
        {

        }
    }
}
