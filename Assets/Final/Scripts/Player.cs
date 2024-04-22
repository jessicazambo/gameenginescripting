using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Week13
{
    public class Player : MonoBehaviour
    {
        public UnityEvent<float> SpeedChangedEvent;
        public float speed;

        //TODO place all of the code that will move the character and get input from the user down below
        //invoke speed changes using SpeedChangedEvent.Invoke(speed);
    }
}