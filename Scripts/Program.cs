namespace ProyectoSDL2.Engine.Scripts
{
    class Program
    {
        static Player player;

        static List<Enemy> enemyList = new List<Enemy>();
        static List<Bullet> bulletList = new List<Bullet>();

        public static List<Enemy> EnemyList => enemyList;
        public static List<Bullet> BulletList => bulletList;


        static float deltaTime;
        static float timerLog = 0;

        public static  float DeltaTime => deltaTime;
        public static float TimerLog => timerLog;
        //{
        //   get => timerLog;
        //    set => timerLog = value;
        //}

        static void Main(string[] args)
        {
            Engine.Initialize();

            DateTime startTime = DateTime.Now;
            
            float currentTime;
            float lastFrameTime = 0;

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

            for (int i = 0; i < enemyList.Count; i++)
            {
                Enemy enemy = enemyList[i];
                enemy.Update();
            }
            for (int i = 0; i < bulletList.Count; i++)
            {
                Bullet bullet = bulletList[i];
                bullet.Update();
            }
        }

        static void Render()
        {
            Engine.Clear();
            player.Render();

            for (int i = 0; i < enemyList.Count; i++)
            {
                Enemy enemy = enemyList[i];
                enemy.Render();
            }
            for (int i = 0; i < bulletList.Count; i++)
            {
                Bullet bullet = bulletList[i];
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