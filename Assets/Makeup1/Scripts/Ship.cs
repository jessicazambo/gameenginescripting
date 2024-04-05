using UnityEngine;
using UnityEngine.InputSystem;

namespace SpaceShooter
{
    public class Ship : MonoBehaviour
    {
        //TODO: Expose a float variable for speed here that you can
        //      change in the inspector

        //TODO: Expose a GameObject variable for the BulletPrefab here that you can
        //      assign the BulletPrefab to in the inspector


        //TODO: Create a private variable referencing the InputMappings file you created here


        //TODO: Create an InputAction variable called m_Move here

        //TODO: Create an InputAction variable called m_Fire here


        private void Awake()
        {
            //TODO: Create a new instance of the InputMappings here and assign it to the variable you created


            //TODO: access the InputMappings variable here and look for Player.Move and assign to the m_Move variable

            //TODO: access the InputMappings variable here and look for Player.Fire and assign to the m_Fire variable

            //TODO: Add the Fire function as listener to the performed action on the m_Fire variable

        }

        private void OnEnable()
        {
            //TODO: Enable m_Move here

            //TODO: Enable m_Fire here

        }

        private void OnDisable()
        {
            //TODO: Disable m_Move here

            //TODO: Disable m_Fire here

        }

        void Update()
        {
            HandleMove();
        }

        void HandleMove()
        {
            //TODO: Call ReadValue on m_Move and pass in a Vector3 datatype instead of Vector3 like we've done before
            //      and store it in a temporary Vector3 called input variable

            //TODO: Create a float variable here called amt and set the value to be speed * Time.deltaTime

            //TODO: Create a Vector3 variable called direction and set the value of it to Vector3.right


            //TODO: translate the transform by (input.x * amt * input)

        }

        void Fire(InputAction.CallbackContext context)
        {
            //TODO: Call instantiate here
            //      The first argument should be the bulletprefab
            //      The second argument should be the position of the ship
            //      The third argument should be the rotation of the bullet prefab

        }
    }
}