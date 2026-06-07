namespace ProyectoSDL2.Engine.Scripts
{
    public class Bullet
    {
        Transform transform;

        public Bullet(int startPosX, int startPosY)
        {
            transform = new Transform(startPosX + 50, startPosY + 60);
        }

        public void Update()
        {
            transform.Translate(0, 7);

            if (transform.PosX + 50 > GameManager.Instance.LevelControl.Player.Transform.PosX &&
                transform.PosX < GameManager.Instance.LevelControl.Player.Transform.PosX + 100 &&
                transform.PosY + 50 > GameManager.Instance.LevelControl.Player.Transform.PosY &&
                transform.PosY < GameManager.Instance.LevelControl.Player.Transform.PosY + 100)
            {
                GameManager.Instance.LevelControl.Player.Health.GetDamage();
                GameManager.Instance.LevelControl.BulletList.Remove(this);
            }
        }

        public void Render()
        {
            Engine.Draw("assets/bullet.png", transform.PosX, transform.PosY);
        }
    }
}
