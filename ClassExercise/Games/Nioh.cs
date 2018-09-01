using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExercise.Games
{
    public class Nioh
    {
        public string Producer { get; set; }
        public string Developer { get; set; }

        public Nioh()
        {
            Producer = "Hisashi Koinuma";
            Developer = "Team Ninja";
        }

        public void Introduce()
        {
            Console.WriteLine("Nioh: I am the best dark soul-like game in 2018!");
        }
        
    }
}
