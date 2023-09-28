using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroGame
{
    public class ThirdScene : Scene
    {
        string name = Console.ReadLine();
        public ThirdScene(Hero hero) : base(hero) 
        {
            
        }

        public override void Describe()
        {
            Console.WriteLine("You decide to investigate the voice you heard in your right ear, " +
                "\n slowly rising from your comfortable seat. Still enchanted by such a sweet voice, you spot a" +
                "\n glowing whisp that you then follow down a dimly lit path, where the dirt beneath your feet glows" +
                "\n a faint yellow with each step you take. You get to the end of the path and notice a group of Nymphs," +
                "\n sitting around a Fly Argic mushroom, with place setttings, much like a dinner table." +
                "\n The Matriarch of the tribe stands and says, 'Welcome! Join us to eat. What is your name?'");
            Console.WriteLine(name + ", you say quietly.");
            Console.WriteLine("'It is quite nice to meet you " + name + ".' She then gestures for you to sit with them. " +
                "\n They all suddenly snap their their heads in your direction to leer at you, their smiles changing from " +
                "\n magnificent to macabre in the blink of an eye. Stunned, unable to speak, you notice you are also unable to move," +
                "\n your body pinned to the seat. Before you have the chance to squeal, the Matriarch is hovering over you. She" +
                "\n places her hands on your shoulders, and lowers her lips to your right ear, 'Truly, " + name + ", Welcome to dinner...'");
        }

        public override ConsoleKeyInfo PresentChoices()
        {
            Console.WriteLine("Press 'Enter'");
            return Console.ReadKey();
        }

        public override Scene HandleChoices(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.Enter) // unsure of which one to use, switch is not working the way i want it to
            {
                hero.LowerVitals(99);
                Console.WriteLine("Better luck next time.");
            }
            else
            {
                Console.WriteLine("You must face your fate!");
            } return EndGame(hero);


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
