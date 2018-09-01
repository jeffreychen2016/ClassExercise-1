using System;
using ClassExercise.Games;

namespace ClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var nioh = new Nioh();
            nioh.Introduce();

            var mhw = new MHW();
            mhw.Introduce();

            var dragonQuestXI = new DragonQuestXI();
            dragonQuestXI.Introduce();

            var angryBird = new AngryBird();
            angryBird.Introduce();
        }
    }
}
