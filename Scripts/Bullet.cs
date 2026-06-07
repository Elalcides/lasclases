using System;

namespace ProyectoSDL2.Engine.Scripts
{
    public class Bullet : GameObject
    {

        public event Action<Bullet> OnDestroy;

        public Bullet(int x, int y) : base(x, y)
        {
        }

        public override void Update()
        {
            transform.Translate(0, -7);
            CollisionCheck();

            //GameManager.Instace.LevelController.Player.Health.GetDamaged();
            //GameManager.Instace.LevelController.GameObjects.Remove(this);
        }

        void CollisionCheck()
        {
            for (int i = 0; i < GameManager.Instace.LevelController.GameObjects.Count; i++)
            {
                GameObject g = GameManager.Instace.LevelController.GameObjects[i];

                if (transform.PosX + 100 > g.Transform.PosX &&
                    transform.PosX < g.Transform.PosX + 70 &&
                    transform.PosY + 100 > g.Transform.PosY &&
                    transform.PosY < g.Transform.PosY + 100)
                {
                    if (g is Enemy)
                    {
                        GameManager.Instace.LevelController.GameObjects.Remove(g);
                        GameManager.Instace.LevelController.GameObjects.Remove(this);

                        Engine.Debug("Colision con algun enemigo");
                        OnDestroy?.Invoke(this);
                    }
                }
            }

            //exit por limite superior
            if(transform.PosY <= 0)
            {
                OnDestroy?.Invoke(this);
                GameManager.Instace.LevelController.GameObjects.Remove(this);
            }
        }


        public override void Render()
        {
            Engine.Draw("assets/bullet.png", transform.PosX, transform.PosY);
        }

    }
}
