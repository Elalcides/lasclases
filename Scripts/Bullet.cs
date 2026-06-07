namespace ProyectoSDL2.Engine.Scripts
{
    public class Bullet : GameObject
    {
        public Bullet(int x, int y) : base(x, y)
        {
        }

        public override void Update()
        {
            transform.Translate(0, 7);
            //GameManager.Instace.LevelController.Player.Health.GetDamaged();
            //GameManager.Instace.LevelController.GameObjects.Remove(this);
        }

        public override void Render()
        {
            Engine.Draw("assets/bullet.png", transform.PosX, transform.PosY);
        }
    }
}
