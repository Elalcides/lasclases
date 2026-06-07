namespace ProyectoSDL2.Engine.Scripts
{
    public class Health
    {
        int health = 200;
        
        public void GetDamage()
        {
            health -= 1;
            Engine.Debug($"Health: {health}");
            if (health <= 0)
            {
                GameManager.Instance.ChangeGameState(GAME_STATE.END);
            }
        }
    }
}
