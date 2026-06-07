namespace ProyectoSDL2.Engine.Scripts
{
    public class PlayerInput
    {
        Transform transform;
        int speed;
        float timer;

        public PlayerInput(Transform playerTransform, int playerSpeed)
        {
            transform = playerTransform;
            speed = playerSpeed;
        }



        public void Update()
        {
            timer += Program.DeltaTime;
            if (Engine.KeyPress(Engine.KEY_A))
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

            if (Engine.KeyPress(Engine.KEY_ESP))
            {
                if (timer > 0.2f)
                {
                    Program.AddBullet(transform.PosX, transform.PosY);
                    timer = 0;
                }


                //no dispares
                
            }
        }
    }
}
