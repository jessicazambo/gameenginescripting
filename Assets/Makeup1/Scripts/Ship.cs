using UnityEngine;
using UnityEngine.InputSystem;

namespace SpaceShooter
{
    public class Ship : MonoBehaviour
    {
        [SerializeField] private float speed = 5f;
        [SerializeField] private GameObject bulletPrefab;

        private ShipControlMappings shipControlMapping;
        private InputAction m_Move;
        private InputAction m_Fire;

        private void Awake()
        {
            shipControlMapping = new ShipControlMappings();

            m_Move = shipControlMapping.Player.Move;
            m_Fire = shipControlMapping.Player.Fire;

            m_Fire.performed += ctx => Fire();
        }

        private void OnEnable()
        {
            m_Move.Enable();
            m_Fire.Enable();
        }

        private void OnDisable()
        {
            m_Move.Disable();
            m_Fire.Disable();
        }

        void Update()
        {
            HandleMove();
        }

        void HandleMove()
        {
            Vector2 input = m_Move.ReadValue<Vector2>();
            float amt = speed * Time.deltaTime;
            Vector3 direction = Vector3.right;

            transform.Translate(input.x * amt * direction);
        }

        void Fire()
        {
            Debug.Log("Fire");
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
    }
}

