
using System.ComponentModel;

namespace ProyectoSDL2.Engine.Scripts
{
    public class NonDynamicPool
    {
        List<Bullet> activeBullets = new List<Bullet>();
        List<Bullet> inactiveBullets = new List<Bullet>();



        public NonDynamicPool(int totalBullets) 
        {

            for (int i = 0; i < totalBullets; i++)
            {
                //crear bala
                Bullet bullet = new Bullet(0,0);
                bullet.OnDestroy += RecycleBullet;
                inactiveBullets.Add(bullet);
            }

        }

        public Bullet GetBullet()
        {
            if(inactiveBullets.Count > 0)
            {
               Bullet temp = inactiveBullets[0];
               activeBullets.Add(temp);
               inactiveBullets.RemoveAt(0);
               return temp;
            }

            return null;
        }

        public void RecycleBullet(Bullet bullet)
        {
            Engine.Debug("Bala reciclada");
            inactiveBullets.Add(bullet);
            activeBullets.Remove(bullet);
        }
    }
}
