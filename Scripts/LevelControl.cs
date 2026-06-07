namespace ProyectoSDL2.Engine.Scripts
{
    public class LevelControl
    {
        Player player;

        List<Enemy> enemyList = new List<Enemy>();
        List<PowerUp> powerUpList = new List<PowerUp>();
        List<Bullet> bulletList = new List<Bullet>();

        public List<Enemy> EnemyList => enemyList;
        public List<PowerUp> PowerUpList => powerUpList;
        public List<Bullet> BulletList => bulletList;
        public Player Player => player;


        public void Update()
        {
            player.Update();
            for (int i = 0; i < enemyList.Count; i++)
            {
                enemyList[i].Update();
            }
            for (int i = 0; i < bulletList.Count; i++)
            {
                bulletList[i].Update();
            }
            for (int i = 0; i < powerUpList.Count; i++)
            {
                powerUpList[i].Update();
            }
        }

        public void Render()
        {
            Engine.Clear();
            player.Render();
            for (int i = 0; i < enemyList.Count; i++)
            {
                enemyList[i].Render();
            }
            for (int i = 0; i < powerUpList.Count; i++)
            {
                powerUpList[i].Render();
            }
            for (int i = 0; i < bulletList.Count; i++)
            {
                bulletList[i].Render();
            }
            Engine.Show();
        }
        public void Start()
        {
            player = new Player(500, 400);

            enemyList.Add(new Enemy(200, 200));
            enemyList.Add(new Enemy(400, 400));
            
            powerUpList.Add(new PowerUp(150, 150));

        }
        public void AddBullet(Bullet bullet)
        {
            bulletList.Add(bullet);
        }
    }
}
