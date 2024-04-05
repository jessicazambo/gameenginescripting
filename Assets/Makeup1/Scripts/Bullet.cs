using UnityEngine;

namespace SpaceShooter
{
    public class Bullet : MonoBehaviour
    {
        //TODO: Expose a float variable for speed here that you can
        //      change in the inspector


        void Update()
        {
            //TODO: Write 1 line of code that moves the bullet UP along the Y axis here
            //      You need to apply speed and Time.deltaTime


            //TODO: Check if the y positive is greater than 7 and if so then destroy the bullet

        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            //TODO: Destroy the bullet here since our collision system will
            //      only detect collisions with asteroids it is safe to assume we hit an asteroid

        }
    }
}