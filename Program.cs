using System.Diagnostics;

namespace ProyectoSDL2.Engine
{
    class Program
    {
        static int posX = 200;
        static Player player;

        static List<Enemy> enemyList = new List<Enemy>();
        public static List<Bullet> bulletList = new List<Bullet>();
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;
            float currentTime;
            float deltaTime;
            float lastFrameTime = 0;
            float timerLog = 0;

            player = new Player(200, 200);

            enemyList.Add(new Enemy(200, 200));
            enemyList.Add(new Enemy(200, 400));
            enemyList.Add(new Enemy(200, 600));
            

            Engine.Initialize();

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

            //player.SetDamage(10);

            //Engine.Debug("Vida: " + player.Health);

            //for (int i = 0; i < enemyList.Count; i++)
            //{
            //    enemyList[i].Update();
            //}

            foreach (Enemy enemy in enemyList)
            {
                enemy.Update();
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

            //for (int i = 0; i < enemyList.Count; i++)
            //{
            //    enemyList[i].Render();
            //}
            Engine.Show();
        }
    }
}
