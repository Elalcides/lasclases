namespace ProyectoSDL2.Engine.Scripts
{
    public class LevelController
    {
        Player player;
        public Player Player => player;

        List<GameObject> gameObjects = new List<GameObject>();
        public List<GameObject> GameObjects => gameObjects;

        public void Start()
        {
            player = new Player(500, 400);

            gameObjects.Add(new Enemy(200, 200));
            gameObjects.Add(new Enemy(200, 400));

            gameObjects.Add(new PowerUp(300, 300));
        }

        public void Update()
        {
            player.Update();
            for (int i = 0; i < gameObjects.Count; i++)
            {
                gameObjects[i].Update();
            }
        }

        public void Render()
        {
            Engine.Clear();

            player.Render();
            for (int i = 0; i < gameObjects.Count; i++)
            {
                gameObjects[i].Render();
            }
            Engine.Show();
        }

        public void AddBulletToList(Bullet bullet)
        {
            gameObjects.Add(bullet);
        }
    }
}
