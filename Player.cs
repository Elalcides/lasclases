namespace ProyectoSDL2.Engine
{
    public class Player
    {
        int posX, posY;
        float speed;
        Image playerImg;

        public Player(int x, int y)
        {
            posX = x;
            posY = y;
            //playerImg = Engine.LoadImage("assets/ship.png");
        }

        public void Update()
        {
            if (Engine.KeyPress(Engine.KEY_A))
            {
                posX--;
            }
            if (Engine.KeyPress(Engine.KEY_D))
            {
                posX++;
            }
            if (Engine.KeyPress(Engine.KEY_W))
            {
                posY--;
            }
            if (Engine.KeyPress(Engine.KEY_S))
            {
                posY++;
            }

        }
        public void Render()
        {
            Engine.Draw("assets/ship.png", posX, posY);
        }



    }
}
