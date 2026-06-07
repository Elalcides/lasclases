using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSDL2.Engine
{
    public class Bullet
    {
        private int posXb, posYb;
        private float bulletSpeed = 5;
                
        public Bullet(int x, int y)
        {
            posXb = x;
            posYb = y;
        }

        public void Update()
        {
            if (Engine.KeyPress(Engine.KEY_P))
            {
                Bullet newBullet = new Bullet(posXb, posYb);
                
                
            }

        }

        public void Render()
        {
            Engine.Draw("assets/bullet.png", posXb, posYb);
        }

    }
}
