using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExercise.Games
{
    class AngryBird
    {
        public string Producer { get; set; }
        public string Developer { get; set; }

        public AngryBird()
        {
            Producer = "Raine Mäki";
            Developer = "Rovio Mobile";
        }

        public void Introduce()
        {
            Console.WriteLine("Angry Birds: Biu~~~~~~~~~~~~!!!!");
        }
    }
}
