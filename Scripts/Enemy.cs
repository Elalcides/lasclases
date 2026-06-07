
namespace ProyectoSDL2.Engine.Scripts
{
    public class Enemy
    {
        Transform transform;
        private Animation enemyAnim;
        int speed = 3;
        Image playerImg;
        //mas
        private List<Image> animationImages = new List<Image>();

        public Enemy(int x, int y)
        {
            transform = new Transform(x, y);

            animationImages.Add(Engine.LoadImage("assets/Enemy/Idle/0.png"));
            animationImages.Add(Engine.LoadImage("assets/Enemy/Idle/1.png"));
            animationImages.Add(Engine.LoadImage("assets/Enemy/Idle/2.png"));
            animationImages.Add(Engine.LoadImage("assets/Enemy/Idle/3.png"));

            enemyAnim = new Animation(animationImages, 0.1f);
            //playerImg = Engine.LoadImage("assets/enemy.png");
        }

        public void Update()
        {
            transform.Translate(speed, 0);

            if (transform.PosX > 1000 || transform.PosX < 0)
            {
                speed *= -1;
            }
            
            enemyAnim.Update();
        }

        public void Render()
        {
            Engine.Draw(enemyAnim.currentFrame, transform.PosX, transform.PosY);
        }

    }
}
