
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrincess
{
   
  
    class GameField
    {
        //Содержимое ячеек с пользователем и с принцессой. Используется для перичного отображеняи поля.
        const int playerCellId = 100;
        const int finishCellId = 200;
        const int trapsCount = 10;
        const int maxTrapDamage = 10;
    
        public int[,] field;
        public Position finalPos;
        public const int size = 10;
      
        public GameField()
        {
            
            field = new int[size, size];
            //Клетка с принцессой
            finalPos = new Position(9, 9);
            field[0, 0] = playerCellId;
            field[finalPos.X, finalPos.Y] = finishCellId;
            int counter = 0;
            Random rnd = new Random();
            while (counter< trapsCount)
            {
                int x = rnd.Next(0, size);
                int y = rnd.Next(0, size);
                //не будем окружать вплотную стартовую позицию игрока и позицию принцессы ловушками.
                if ((x < 3 && y < 3) || (x > 7 && y > 7))
                    continue;
                if (field[x, y] == 0)
                {
                    field[x, y] = rnd.Next(1,maxTrapDamage);
                    counter++;
                }
            }
            
        }
        public void Print(bool showTraps=false)
        {
            for (int i=0;i< size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                   Console.SetCursorPosition(i, j);
                   switch(field[i, j])
                    {
                        case 0:
                            {
                                Console.Write('.');
                                break;
                            }
                        case playerCellId:
                            {
                                Console.Write("P");
                                break;
                            }
                        case finishCellId:
                            {
                                Console.Write("F");
                                break;
                            }
                        default:
                            {
                                if(showTraps)
                                    Console.Write(field[i, j]);
                                else
                                    Console.Write('.');
                                break;
                            }
                    }
                       
                }
            }
            Console.WriteLine();
        }
    }
}
