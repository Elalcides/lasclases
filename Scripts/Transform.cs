using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSDL2.Engine.Scripts
{
    public class Transform
    {
        //posiciones
        Vector2 position;

        public int PosX => position.x; 
        public int PosY => position.y;

        //constructor
        public Transform(int x, int y)
        {
            position = new Vector2(x, y);
        }

        //translate
        public void Translate(int moveX, int moveY)
        {
            position.x += moveX;
            position.y += moveY;
        }

        public void SetPosition(int x, int y)
        {

            position.x = x;
            position.y = y;
        }


    }
}
