using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSDL2.Engine
{
    public class Enemy
    {
        int posX, posY;
        int speed = 3;
        //mas

        public Enemy(int x, int y)
        {
            posX = x;
            posY = y;
            //playerImg = Engine.LoadImage("assets/ship.png");
        }

        public void Update()
        {
            posX += speed;

            if(posX > 1000 || posX < 0)
            {
                speed *= -1;
            }    

        }

        public void Render()
        {
            Engine.Draw("assets/enemy.png", posX, posY);
        }

    }
}
