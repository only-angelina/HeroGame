using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroGame
{
    public class FourthScene : Scene
    {
        public FourthScene(Hero hero) : base(hero) 
        {

        }

        public override void Describe()
        {
            Console.WriteLine("'Thank you, oh kind one!' Over the the days that follow, you learn the history of the" +
                "\n fairies, as well as their magic, and how to defend against the Nymphs. 'You are ready, young one...'" +
                "\n You and the army march in unison to towards the Nymph territory, prepared for battle. " +
                "\n 'There is their Queen,' the Patriarch states. You straighten your back and declare that you and the" +
                "\n fairies are prepared to negotiate a deal." +
                "\n In the time it took you to catch your breath, you and the army were surrounded by the Nymphs, the Matriarch" +
                "\n approaching you slowly, with long strides. 'Oh, I believe you're outnumberes...' she says, and " +
                "\n the last thing you see is her sharp, sinister sneer...");
        }

        public override ConsoleKeyInfo PresentChoices()
        {
            Console.WriteLine("Press 'Enter' to continue");
            return Console.ReadKey();
        }

        public override Scene HandleChoices(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Better luck next time.");
            }
            else
            {
                Console.WriteLine("You must face your fate!");
            }
            //switch (key.KeyChar)
            //{
            //    case 'x':
            //        hero.LowerVitals(99);
            //        Console.WriteLine("wek ");
            //        break;
            //    default:
            //        Console.WriteLine("You must face your fate!");
            //        return this;
            //}
        }
    }
}
