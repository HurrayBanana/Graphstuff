using System;
using System.Collections.Generic;
using System.Text;

namespace Graphstuff
{
    class Animal
    {
        private float weight;
        private string name;
        private DateTime born;

        public float Weight
        {
            get { return weight; }
            set
            {
                if (weight > 0)
                    weight = value;
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (!String.IsNullOrEmpty(value) && value.Length <= 30)
                {
                    name = value;
                }
            }
        }
        public DateTime Born
        {
            get { return born; }
            set { born = value; }
        }
        public Animal(string name, float weight)
        {
            this.name = name;
            this.weight = weight;
        }
    }
}
