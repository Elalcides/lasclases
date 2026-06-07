
namespace ProyectoSDL2.Engine.Scripts
{
    public class DynamicPool
    {
        List<Bullet> activeBullets = new List<Bullet>();
        List<Bullet> inactiveBullets = new List<Bullet>();

        public DynamicPool()
        {

        }

        public Bullet GetBullet()
        {
            if (inactiveBullets.Count > 0)
            {
                Bullet temp = inactiveBullets[0];
                activeBullets.Add(temp);
                inactiveBullets.RemoveAt(0);
                return temp;
            }
            else
            {
                Bullet bullet = new Bullet(0,0);
                bullet.OnDestroy += RecycleBullet;
                activeBullets.Add(bullet);
                return bullet;
            }

           
        }

        public void RecycleBullet(Bullet bullet)
        {
            Engine.Debug("Bala reciclada\n");
            Engine.Debug($"Balas activas {activeBullets.Count} \n");
            Engine.Debug($"Balas inactivas {inactiveBullets.Count} \n");
            inactiveBullets.Add(bullet);
            activeBullets.Remove(bullet);
        }
    }
}
