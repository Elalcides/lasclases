using System.Diagnostics;

namespace ProyectoSDL2.Engine.Scripts
{
    class Program
    {
        static Player player;

        static List<Enemy> enemyList = new List<Enemy>();
        static List<Bullet> bulletList = new List<Bullet>();

        public static float deltaTime;

        public static float DeltaTime => deltaTime;

        static void Main(string[] args)
        {
            Engine.Initialize();

            DateTime startTime = DateTime.Now;
            float currentTime;
            float lastFrameTime = 0;
            float timerLog = 0;


            player = new Player(200, 200);

            enemyList.Add(new Enemy(200, 200));
            enemyList.Add(new Enemy(200, 400));
            enemyList.Add(new Enemy(200, 600));


            while (true)
            {
                currentTime = (float)(DateTime.Now - startTime).TotalSeconds; //calculo el tiempo actual
                deltaTime = currentTime - lastFrameTime; //tiempo actual - tiempo del ultimo frame
                lastFrameTime = currentTime; //este es ahora mi ultimo frame
                timerLog += deltaTime;

                Update();
                Render();
            }

        }

        static void Update()
        {
            player.Update();

            player.SetDamage(10);

            foreach (Enemy enemy in enemyList)
            {
                enemy.Update();
            }
            foreach (Bullet bullet in bulletList)
            {
                bullet.Update();
            }
        }

        static void Render()
        {
            Engine.Clear();
            player.Render();

            foreach (Enemy enemy in enemyList)
            {
                enemy.Render();
            }
            foreach (Bullet bullet in bulletList)
            {
                bullet.Render();
            }

            Engine.Show();
        }

        public static void AddBullet(int posX, int posY)
        {
            bulletList.Add(new Bullet(posX, posY));
        }

    }

}

