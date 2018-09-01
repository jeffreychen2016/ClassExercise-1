using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExercise.Games
{
    class MHW
    {
        public string Producer { get; set; }
        public string Developer { get; set; }

        public MHW()
        {
            Producer = "Ryozo Tsujimoto";
            Developer = "Capcom";
        }

        public void Introduce()
        {
            Console.WriteLine("MHW: I am the best selling game in 2018!");
        }
    }
}
