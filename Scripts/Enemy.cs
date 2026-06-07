
namespace ProyectoSDL2.Engine.Scripts
{
    public class Enemy
    {
        Transform transform;
        EnemyMovement enemyMovement;
        Weapon weapon;
        Animation animation;
        
        List<Image> enemyAnimImgs = new List<Image>();
        
        public Enemy(int startPosX, int startPosY)
        {
            transform = new Transform(startPosX, startPosY);
            enemyMovement = new EnemyMovement(transform);
            weapon = new Weapon(transform);
            enemyAnimImgs.Add(Engine.LoadImage("assets/enemy/0.png"));
            enemyAnimImgs.Add(Engine.LoadImage("assets/enemy/1.png"));
            enemyAnimImgs.Add(Engine.LoadImage("assets/enemy/2.png"));
            enemyAnimImgs.Add(Engine.LoadImage("assets/enemy/3.png"));
            animation = new Animation(enemyAnimImgs, 0.1f);
        }
        public void Update()
        {
            animation.Update();
            enemyMovement.MoveEnemy();
            weapon.Shoot();
        }

        public void Render()
        {
            Engine.Draw(animation.currentFrame, transform.PosX, transform.PosY);
        }
    }
}