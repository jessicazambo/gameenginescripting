using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Week6;

namespace Week6
{
    public class PlayerController : MonoBehaviour
    {

        [SerializeField] int maxHealth = 100;
        int currentHealth;

        [SerializeField] int maxKeys = 3;
        int keyCount = 0;

        [SerializeField] int maxCoins = 99;
        int coinCount = 0;

        [SerializeField] float speed;
        [SerializeField] float jumpForce;
        [SerializeField] float rotationVertical = 5.0f;
        [SerializeField] float rotationHorizontal = 5.0f;

        private float mouseDeltaX = 0f; 
        private float mouseDeltaY = 0f; 
        private float cameraRotX = 0f; 
        private int rotDir = 0;

        PlayerControllerMappings playerMappings;

        InputAction move;
        InputAction fire;
        InputAction jump;
        InputAction look;

        Rigidbody rb;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();

            playerMappings = new PlayerControllerMappings();
            move = playerMappings.Player.Move;

            fire = playerMappings.Player.Fire;
            fire.performed += Fire;

            jump = playerMappings.Player.Jump;
            jump.performed += Jump;

            look = playerMappings.Player.Look;

        }


        private void OnEnable()
        {
            move.Enable();
            fire.Enable();
            jump.Enable();
            look.Enable();
        }

        private void OnDisable()
        {
            move.Disable();
            fire.Disable();
            jump.Disable();
            look.Disable();
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        private void Update()
        {
            HandleHorizontalRotation();
            HandleVerticalRotation();
        }

        void HandleHorizontalRotation() 
        { 
            mouseDeltaX = look.ReadValue<Vector2>().x; 
            if (mouseDeltaX != 0) 

            { 
                rotDir = mouseDeltaX > 0 ? 1 : -1; 
                transform.eulerAngles += new Vector3(0, rotationHorizontal * Time.deltaTime * rotDir, 0); 
            } 
        }
        
        void HandleVerticalRotation()
        {
            mouseDeltaY = look.ReadValue<Vector2>().y; 
            
            if (mouseDeltaY != 0)
            {
                rotDir = mouseDeltaY > 0 ? -1 : 1; 

                cameraRotX += rotationVertical  * Time.deltaTime * rotDir; 
                cameraRotX = Mathf.Clamp(cameraRotX, -45f, 45f); 

                var targetRotation = Quaternion.Euler(Vector3.right * cameraRotX); 
                
                //Vector3 angle = new Vector3(rotation * Time.deltaTime * rotDir, 0, 0);
                
                Debug.Log(Camera.main.transform.localRotation.x);
                Camera.main.transform.localRotation = targetRotation; 
                
                //Camera.main.transform.Rotate(angle, Space.Self);
            } 
        }

        // Update is called once per frame
        void FixedUpdate() 
        { 
            Vector2 input = move.ReadValue<Vector2>(); 
            Vector3 direction = (input.x * transform.right) + (transform.forward * input.y); 
            
            transform.position = transform.position + (direction * speed * Time.deltaTime); 
        }

        void Fire(InputAction.CallbackContext context)
        {
            Debug.Log("Fire!");
        }

        void Jump(InputAction.CallbackContext context)
        {
            Debug.Log("Jump!");
            rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        }

        private bool m_HasKey = false;

        public bool HasKey()
        {
            return m_HasKey;
        }

        public void AddKey()
        {
            m_HasKey = true;
            Debug.Log("Key added to inventory");
        }

        public void RemoveKey()
        {
            m_HasKey = false;
            Debug.Log("Key removed from inventory");
        }
    }
}
