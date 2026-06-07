namespace ProyectoSDL2.Engine.Scripts
{
    public class Enemy : GameObject
    {
        int initialX, initialY;
        EnemyMovement enemyMovement;
        Weapon weapon;
        Animation animation;

        List<Image> images = new List<Image>();

        public Enemy(int startPosX, int startPosY) : base(startPosX, startPosY)
        {
            initialX = startPosX;
            initialY = startPosY;

            enemyMovement = new EnemyMovement(transform);
            weapon = new Weapon(transform);

            images.Add(Engine.LoadImage("assets/enemy/0.png"));
            images.Add(Engine.LoadImage("assets/enemy/1.png"));
            images.Add(Engine.LoadImage("assets/enemy/2.png"));
            images.Add(Engine.LoadImage("assets/enemy/3.png"));

            animation = new Animation(images, 0.1f);

            Health.OnDie += ResetPosition;
        }

        public override void Update()
        {
            animation.Update();
            enemyMovement.MoveEnemy();
            weapon.Shoot();
        }

        public override void Render()
        {
            Engine.Draw(animation.currentFrame, transform.PosX, transform.PosY);
        }

        void ResetPosition()
        {
            //moveme
            transform.SetPosition(initialX, initialY); //si si
        }
    }
}
