using System.Runtime.InteropServices;

namespace HeroGame
{
    public class Program // game starts here
    {
        static void Main(string[] args)
        { //ReadKey() : obtains next character or function key pressed by user
            Hero hero = new Hero(100); // hero creation
            Scene currentScene = new FirstScene(hero); // game begins


                currentScene.Describe();
                currentScene.PresentChoices();
                currentScene = currentScene.HandleChoices(Console.ReadKey()); // or (Console.ReadKey(true).Key);


            try
            {
                while (hero.Vitality > 0)
                {
                    currentScene = currentScene.HandleChoices(currentScene.PresentChoices()); 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // GAME OVER
            Console.WriteLine("GAME OVER" + "\n Moral of the story: Don't be a hero, finish your tea!");
            //Console.WriteLine("The moral of the story is: Curiosity always killed the cat... or in this case, the Cabin Dweller...");
            Console.ReadKey();
        }
    }
}