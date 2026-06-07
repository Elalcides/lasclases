namespace ProyectoSDL2.Engine.Scripts
{
    public class Player : GameObject
    {
        PlayerInput input;
        Health health;

        bool isActive = true;

        public PlayerInput Input => input;
        public Health Health => health;

        public Player(int startPosX, int startPosY) : base(startPosX, startPosY) 
        {
            health = new Health();
            input = new PlayerInput(transform);

            Health.OnDie += Death;
        }

        public override void Render()
        {
            if (isActive)
            {
                Engine.Draw("assets/ship.png", transform.PosX, transform.PosY);
            }
        }

        public override void Update()
        {
            if (isActive)
            {
                input.Update();
                CollisionCheck();
            }
        }

        void Death()
        {
            Engine.Debug("Evento llamado");
            isActive = false;
        }

        public void CollisionCheck()
        {
            for (int i = 0; i < GameManager.Instace.LevelController.GameObjects.Count; i++)
            {
                GameObject g = GameManager.Instace.LevelController.GameObjects[i];

                if (transform.PosX + 100 > g.Transform.PosX &&
                    transform.PosX < g.Transform.PosX + 70  &&
                    transform.PosY + 100 > g.Transform.PosY &&
                    transform.PosY < g.Transform.PosY + 70)
                {
                    if (g is Enemy)
                    {
                        //Engine.Debug("Colision con algun enemigo");
                    }
                    else if (g is Bullet)
                    {
                        health.GetDamaged();
                        GameManager.Instace.LevelController.GameObjects.Remove(g);
                    }
                    else if (g is IPickup)
                    {
                        IPickup pickup = (IPickup)g;
                        pickup.DoEffect();
                        //Engine.Debug("Colision con pick up");
                    }
                }
            }
        }
    }
}
