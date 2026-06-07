namespace ProyectoSDL2.Engine.Scripts
{
    public class EnemyMovement
    {
        Transform transform;
        int speed = 5;
        
        public EnemyMovement(Transform newTransform)
        {
            transform = newTransform;
        }


        public void MoveEnemy()
        {
            if (transform.PosX < 0 || transform.PosX > 1000)
            {
                speed *= -1;
            }
            transform.Translate(speed, 0);
        }
    }
}
