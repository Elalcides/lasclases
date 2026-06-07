namespace ProyectoSDL2.Engine.Scripts
{
    public class Weapon
    {
        float timer = 0;
        Transform transform;

        public Weapon(Transform enemyTransform)
        {
            transform = enemyTransform;

        }
        public void Shoot()
        {
            timer += Program.DeltaTime;

            if(timer > 2f)
            {
                Engine.Debug("Shoot");
                GameManager.Instance.LevelControl.AddBullet(new Bullet(transform.PosX,transform.PosY));
                timer = 0;
            }
        }
    }
}
