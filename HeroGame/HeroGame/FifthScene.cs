using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroGame
{
    public class FifthScene : Scene
    {
        public FifthScene(Hero hero) : base(hero)
        {

        }

        public override void Describe()
        {
            Console.WriteLine(" 'How dare you forsake us! Sick 'em!' The Patriarch proceeded to release his feral hedgehogs on you." +
                "\n As you turn on your heal to run back home and salvage your life. As they run, you look back and notice they have become" +
                "\n the size of the Evergreens that surround you. You run as fast as you can, but begin to feel hot air and wet droplets" +
                "\n stinging the back of your neck, and then.... darkness...");
        }

        public override ConsoleKeyInfo PresentChoices()
        {
            Console.WriteLine("Press 'Enter' to continue.");
            return Console.ReadKey();
        }

        public override Scene HandleChoices(ConsoleKeyInfo key)
        {

            if (key.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Better luck next time");
            }
            else
            {
                Console.WriteLine("You must face your fate!");
            }
            
            //switch (key.KeyChar)
            //{
            //    case 'x':
            //        hero.LowerVitals(99);
            //        Console.WriteLine("Better luck next time.");
            //        break;
            //    default:
            //        Console.WriteLine("You must face your fate!");
            //        return this;
            //}
        }
    }
}
