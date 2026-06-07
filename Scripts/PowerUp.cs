namespace ProyectoSDL2.Engine.Scripts
{
    public class PowerUp
    {
        Transform transform;

        public PowerUp(int startPosX, int startPosY)
        {
            transform = new Transform(startPosX, startPosY);
        }

        public void Update()
        {
            if(transform.PosX + 50 > GameManager.Instance.LevelControl.Player.Transform.PosX && 
                transform.PosX < GameManager.Instance.LevelControl.Player.Transform.PosX + 100 &&
                transform.PosY + 50 > GameManager.Instance.LevelControl.Player.Transform.PosY && 
                transform.PosY < GameManager.Instance.LevelControl.Player.Transform.PosY + 100)
            {
                Engine.Debug("Colision con PowerUp");
                GameManager.Instance.LevelControl.Player.PlayerInput.UpdateSpeed(10);
                GameManager.Instance.LevelControl.PowerUpList.Remove(this);
            }

        }

        public void Render()
        {
            Engine.Draw("assets/powerup.png", transform.PosX, transform.PosY);
        }
    }
}