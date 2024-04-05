using UnityEngine;

namespace SpaceShooter
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float speed = 10f;

        void Update()
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);

            if (transform.position.y > 7)
            {
                Destroy(gameObject);
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            Destroy(gameObject);
        }
    }
}
