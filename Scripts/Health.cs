using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSDL2.Engine.Scripts
{
    public class Health
    {
        public static event Action OnDie;
        int health = 2;

        public void GetDamaged()
        {
            health -= 1;
            Engine.Debug($"Vida: {health}");

            if(health <= 0)
            {
                OnDie?.Invoke();
               // GameManager.Instace.ChangeGameState(GAME_STATE.END);
            }
        }
    }
}
