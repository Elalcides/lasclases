using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSDL2.Engine.Scripts
{

    struct Vector2
    {
        public int x, y;

        public Vector2(int x, int y)
        {
            this.x = x;
            this.y = y;

            
        }
        public int Distance(Vector2 other)
        {
            return x - other.x;
        }
    }
}



