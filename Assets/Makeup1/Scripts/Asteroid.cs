using UnityEngine;

namespace SpaceShooter
{
    public class Asteroid : MonoBehaviour
    {
        [SerializeField] private float speed = 2f;
        private Vector3 initialPosition;

        private void Start()
        {
            initialPosition = transform.position;
        }

        private void Update()
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);

            if (transform.position.y < -6)
            {
                ResetPosition();
            }
        }

        private void ResetPosition()
        {
            transform.position = initialPosition;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Bullet"))
            {
                ResetPosition();
                ScoreManager.IncrementScore();
            }
        }
    }
}
