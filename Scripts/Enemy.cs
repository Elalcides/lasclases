
namespace ProyectoSDL2.Engine.Scripts
{
    public class Enemy
    {
        Transform transform;
        int speed = 3;
        Image playerImg;
        //mas

        public Enemy(int x, int y)
        {
            transform = new Transform(x, y);
            playerImg = Engine.LoadImage("assets/enemy.png");
        }

        public void Update()
        {
            transform.Translate(speed, 0);

            if (transform.PosX > 1000 || transform.PosX < 0)
            {
                speed *= -1;
            }

        }

        public void Render()
        {
            Engine.Draw(playerImg, transform.PosX, transform.PosY);
        }

    }
}
