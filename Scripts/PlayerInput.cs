
namespace ProyectoSDL2.Engine.Scripts
{
    public class PlayerInput
    {
        Transform transform;
        int speed = 5;

        //algo para usar speed y transform

        public PlayerInput(Transform playerTransform)
        {
            transform = playerTransform;
        }
        public void Update()
        {
            if(Engine.KeyPress(Engine.KEY_A))
            {
                transform.Translate(-1 * speed, 0);
            }
            if (Engine.KeyPress(Engine.KEY_D))
            {
                transform.Translate(1 * speed, 0);
            }
            if (Engine.KeyPress(Engine.KEY_W))
            {
                transform.Translate(0, -1 * speed);
            }
            if (Engine.KeyPress(Engine.KEY_S))
            {
                transform.Translate(0, 1 * speed);
            }
            Engine.KeyPress(Engine.KEY_ESP);
            {
            //    if (timerLog < 0.5f)
            //    {
                    GameManager.Instance.LevelControl.AddBullet(new Bullet(transform.PosX, transform.PosY));
            //        timerLog = 0;
            //    }
            }
        }
        public void UpdateSpeed(int newSpeed)
        {
            speed = newSpeed;
        }
    }
}
