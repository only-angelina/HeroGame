using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroGame // story-mode
{
    public class FirstScene : Scene
    {
        public FirstScene(Hero hero) : base(hero)
        {

        }

        public override void Describe()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("You live a quiet, peaceful life in a small yet comfortable cabin in the woods, away from the hectic city. You woke up" +
           "\n this morning, made a small cup of your favourite herbal tea, and went to relax on the grass in your backyard, " +
           "\n soaking in the beautiful view of the sunrise above the lake ahead." +
           "\n Suddenly, you hear a raspy, skin-crawling voice whisper in your left ear saying, " +
           "\n\"Come find me..." +
           "\n You practically jump out of your skin, hardly having time to recover before hearing another voice," +
           "\n\"No, you must find me..." +
           "\n This voice was different. It was softer, sparkling, and serene.");
        }

        public override ConsoleKeyInfo PresentChoices()
        {
            Console.WriteLine("What will you do?");
            Console.WriteLine("a): Go look for where the sound came from.");
            Console.WriteLine("b): Enjoy the rest of your tea and continue watching the sun rise.");
            Console.WriteLine("You've decided to: ");
            return Console.ReadKey();
        }

        public override Scene HandleChoices(ConsoleKeyInfo key)
        {
            switch (key.KeyChar)
            {
                case 'a':
                    return new SecondScene(hero);
                case 'b':
                    return new ThirdScene(hero);
            }

        }

    }
}
