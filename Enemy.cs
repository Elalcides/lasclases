namespace ProyectoSDL2.Engine
{
    public class Enemy
    {
        int posX, posY;
        int speed = 3;
        Image enemyImg;

        public Enemy(int x, int y)
        {
            posX = x;
            posY = y;
            //enemyImg = Engine.LoadImage("assets/ship.png");
        }
        public void Update()
        {
            posX += speed;
            if (posX > 1000 || posX < 0)
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
