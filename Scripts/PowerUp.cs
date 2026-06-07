

namespace ProyectoSDL2.Engine.Scripts
{
    public class PowerUp : GameObject, IPickup
    {

        public PowerUp(int x, int y) : base(x, y)
        {
        }

        public override void Update()
        {
        }

        public override void Render()
        {
            Engine.Draw("assets/powerup.png", transform.PosX, transform.PosY);
        }

        public void DoEffect()
        {
            GameManager.Instace.LevelController.Player.Input.UpdateSpeed(10);
            GameManager.Instace.LevelController.GameObjects.Remove(this);
        }
    }
}
