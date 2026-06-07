
namespace ProyectoSDL2.Engine.Scripts
{
    public class EmemyDynamicPool
    {

        //Claude armame un pool generico
        List<Enemy> activeBullets = new List<Enemy>();
        List<Enemy> inactiveBullets = new List<Enemy>();

        public EmemyDynamicPool()
        {

        }

        public Enemy GetBullet()
        {
            if (inactiveBullets.Count > 0)
            {
                Enemy temp = inactiveBullets[0];
                activeBullets.Add(temp);
                inactiveBullets.RemoveAt(0);
                return temp;
            }
            else
            {
                Enemy bullet = new Enemy(0, 0);
                //bullet.OnDestroy += RecycleBullet;
                activeBullets.Add(bullet);
                return bullet;
            }


        }

        public void RecycleBullet(Enemy bullet)
        {
            Engine.Debug("Bala reciclada\n");
            Engine.Debug($"Balas activas {activeBullets.Count} ");
            Engine.Debug($" Balas inactivas {inactiveBullets.Count} \n");
            inactiveBullets.Add(bullet);
            activeBullets.Remove(bullet);
        }
    }
}
