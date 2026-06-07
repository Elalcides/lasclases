namespace ProyectoSDL2.Engine
{
    public class Player
    {
        private int posX, posY;
        private float speed;
        private float health;

        public float Health => health;

        //public void SetHealth(float newHealth)
        //    { health = newHealth; }

        //public float GetHealth()
        //{ 
        //    return health;
        //}

        //public float Health
        //{
        //    get
        //    {
        //        if(health >0)
        //        {
        //            return health;
        //        }
        //        return 0;
        //    }
        //    set
        //    {
        //        if(value <= 5)
        //        {
        //            health = value;
        //        }
                
        //    }
        //}



        private Image playerImg;
        //mas

        public void SetDamage(int damage)
        {
            
            health -= damage;

            if(health < 0)
            {
                // murio
            }
        }

        public Player(int x, int y)
        {
            posX = x;
            posY = y;
            //playerImg = Engine.LoadImage("assets/ship.png");
        }

        public void Update()
        {
            if(Engine.KeyPress(Engine.KEY_A))
            {
                posX--;
            }

            if (Engine.KeyPress(Engine.KEY_D))
            {
                posX++;
            }

            if (Engine.KeyPress(Engine.KEY_W))
            {
                posY--;
            }

            if (Engine.KeyPress(Engine.KEY_S))
            {
                posY++;
            }

        }

        public void Render()
        {
            Engine.Draw("assets/ship.png", posX, posY);
        }

    }
}
