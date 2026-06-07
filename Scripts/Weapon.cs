using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSDL2.Engine.Scripts
{
    public class Weapon
    {
        float timer = 0;
        private Transform transform;
        //DynamicPool<Bullet> bulletPool;

        public Weapon(Transform enemyTransform)
        {
            transform = enemyTransform;
            //bulletPool = new DynamicPool<Bullet>();
        }


        public void Update()
        {
            timer += Program.DeltaTime;
        }
        public void Shoot()
        {
            if (timer >= 0.36)
            {
                //Engine.Debug("Disparo");
                //Bullet temp = bulletPool.GetBullet();
                /*temp?.Transform.SetPosition(transform.PosX, transform.PosY);
                if(temp != null) 
                    GameManager.Instace.LevelController.AddBulletToList(temp);*/

                timer = 0;
            }
        }
    }
}
