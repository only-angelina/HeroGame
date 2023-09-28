using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroGame
{
    public class SecondScene : Scene
    {
        public SecondScene(Hero hero) : base(hero)
        {

        }

        public override void Describe()
        {
            Console.WriteLine("You decide to investigate the voice you heard in your left ear." +
                "\n Unsure of whether or not self-defense will be required, you head out into the woods, your heart racing." +
                "\n Finally, you find a family of creatures, resembling fairies, but quite sickly-looking." +
                "\n Ypu question who they are, and the Patriarch of the family speaks up to explain. The Nymphs of the" +
                "\n forest have been stealing the fairies' magic for generations to make themselves more enchanting and" +
                "\n lead the forest's visitors to their demise. Every new resident of the forest falls for their glamour" +
                "\n but you are the first to go against the grain. Then the Patriarch asks a question:");
        }

        public override ConsoleKeyInfo PresentChoices()
        {
            Console.WriteLine("Will you help us?");
            Console.WriteLine("Press 'y' for yes and 'n' for no");
            return Console.ReadKey();
        }

        public override Scene HandleChoices(ConsoleKeyInfo key)
        {
            switch (key.KeyChar)
            {
                case 'y':
                    return new FourthScene(hero);
                case 'n':
                    return new FifthScene(hero);
                default:
                    Console.WriteLine("You must decide!");
                    return this;
            }
        }
    }
}
