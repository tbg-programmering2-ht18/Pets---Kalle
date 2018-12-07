using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Animal
    {
        public string Name { get; set; }
        public string Sound { get; set; }
        public bool CanFly { get; set; }

        public string Show()
        {
            if (CanFly == true)
            {
                return String.Format("name: {0}\nSound: {1}\nType: {2} and can fly", Name, Sound, GetType());
            }
            else
            {
                return String.Format("name: {0}\nSound: {1}\nType: {2}", Name, Sound, GetType());
            }
        }

    }
    class Dog : Animal
    {
        public Dog(String name)
        {
            Name = name;
            Sound = "WOF";
            CanFly = false;
        }
    }
    class Cat : Animal
    {
        public Cat(String name)
        {
            Name = name;
            Sound = "grrrrrrrrrrrrrrrrrrrrrr";
            CanFly = false;
        }
    }
    class Bird : Animal
    {
        public Bird(String name)
        {
            Name = name;
            Sound = "Moooooooo (totaly a cow! :3)";
            CanFly = true;
        }
    }
}