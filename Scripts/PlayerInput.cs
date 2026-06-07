namespace ProyectoSDL2.Engine.Scripts
{
    public class PlayerInput
    {
        private Transform transform;
        private int speed = 5;
        public PlayerInput(Transform playerTransform, int speed)
        {
            this.transform = playerTransform;
            this.speed = speed;
            //Engine.OnKeyDown += HandleKeyDown;
        }

        public void Update()
        {
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
                Program.AddBullet(transform.PosX, transform.PosY);
            }


            //if (Engine.IsKeyDown("W"))
            //{
            //    //mover hacia arriba
            //}
            //if (Engine.IsKeyDown("S"))
            //{
            //    //mover hacia abajo
            //}
            //if (Engine.IsKeyDown("A"))
            //{
            //    //mover hacia izquierda
            //}
            //if (Engine.IsKeyDown("D"))
            //{
            //    //mover hacia derecha
            //}
        }
    }
}
