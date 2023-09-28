using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroGame
{
    public abstract class Scene // common interface or abstract class
    {

            protected Hero hero;

            public Scene(Hero hero)
            {
                this.hero = hero;
            }

            public abstract void Describe();

            public abstract ConsoleKeyInfo PresentChoices();

            public abstract Scene HandleChoices(ConsoleKeyInfo key);


    }
}
