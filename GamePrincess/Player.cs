using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrincess
{
    class Player
    {
        //Текущая позиция игрока
        public Position pos;
        //Жизни игрока
        public int hp;
        public Player()
        {
            pos = new Position(0, 0);
            hp = 10;
        }
        public void MoveLeft()
        {
            pos.X--;
        }
        public void MoveUp()
        {
            pos.Y--;
        }
        public void MoveRight()
        {
            pos.X++;
        }
        public void MoveDown()
        {
            pos.Y++ ;
        }
    }
}
