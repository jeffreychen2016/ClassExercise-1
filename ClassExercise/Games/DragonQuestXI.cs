using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExercise.Games
{
    class DragonQuestXI
    {
        public string Producer { get; set; }
        public string Developer { get; set; }

        public DragonQuestXI()
        {
            Producer = "Yosuke Saito";
            Developer = "Square Enix";
        }

        public void Introduce()
        {
            Console.WriteLine("DragonQuestXI: I am the most popular game in Japan!");
        }
    }
}
