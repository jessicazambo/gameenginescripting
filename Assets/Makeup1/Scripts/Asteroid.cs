using UnityEngine;

namespace SpaceShooter
{
    public class Asteroid : MonoBehaviour
    {
        //TODO: Expose a float variable for speed here that you can
        //      change in the inspector


        void Update()
        {
            //TODO: Write 1 line of code that moves the bullet DOWN along the Y axis here
            //      You need to apply speed and Time.deltaTime


            //TODO: Check if the y positive is less than -6 and if so then call ResetPosition

        }

        void ResetPosition()
        {
            //TODO: Set the position of the asteroid to be above the camera view
            //      Keep the X position the same and the Z position as 0

        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            //TODO: Call reset position since we either hit a bullet or the ship


            //TODO: Check if the other object has a tag called Bullet and if so call the Static IncrementScore function 
            //      on the ScoreManager

        }
    }
}