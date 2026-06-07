
namespace ProyectoSDL2.Engine.Scripts
{
    public class PlayerInput
    {
        private Transform transform;
        private int speed = 5;
        private Weapon weapon;

        public PlayerInput(Transform playerTransform, Weapon weapon)
        {
            transform = playerTransform;
            this.weapon = weapon;
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
            if(Engine.KeyPress(Engine.KEY_ESP))
            {
                weapon.Shoot();
            }

        }

        public void UpdateSpeed(int newSpeed)
        {
            speed = newSpeed;
        }

    }
}
