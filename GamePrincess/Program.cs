using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrincess
{
    class Program
    {
        


        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Player player = new Player();
                GameField gameField = new GameField();
                Game game = new Game(gameField, player);
                //CHEAT: установить в true, чтобы видеть ловушки
                bool showTraps=false;
                game.Start(showTraps);

                Console.WriteLine("\nOne more time?(y/n)");
                bool stopAsk = false;
                while (!stopAsk)
                {
                    string answer = Console.ReadLine();
                    switch (answer)
                    {
                        case "n":
                            {
                                stopAsk = true;
                                exit = true;
                                break;
                            }
                        case "y":
                            {
                                stopAsk = true;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Specify either 'y' or 'n'");
                                break;
                            }
                    }
                }    
            }
        }
    }
}
