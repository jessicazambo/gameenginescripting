using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace Week6
{
    public class DoorTrigger : MonoBehaviour
    {
        [SerializeField] Transform m_DoorTransform;
        [SerializeField] Vector3 m_PositionOpenOffset;
        [SerializeField] bool m_RequiresKey = true; // Indicates if the door requires a key to open
        bool m_IsOpening;
        float m_Alpha;

        private Vector3 m_PositionClose;
        private Vector3 m_PositionOpen;

        private void Awake()
        {
            m_PositionClose = m_DoorTransform.position;
            m_PositionOpen = m_PositionOpenOffset + m_PositionClose;
        }

        private void Update()
        {
            if (m_IsOpening) m_Alpha += Time.deltaTime;
            else m_Alpha -= Time.deltaTime;
            m_Alpha = Mathf.Clamp(m_Alpha, 0, 1);

            m_DoorTransform.position = Vector3.Lerp(m_PositionClose, m_PositionOpen, m_Alpha);
        }

        private void OnTriggerEnter(Collider other)
        {
            PlayerController player = other.GetComponent<PlayerController>();
            if (player != null && player.HasKey())
            {
                OpenDoor();
                player.RemoveKey();
            }
        }

        private void OnTriggerStay(Collider other)
        {
            // You can add additional behavior if needed while the player stays within the trigger
        }

        private void OnTriggerExit(Collider other)
        {
            CloseDoor();
        }

        private void OpenDoor()
        {
            Debug.Log("Door Trigger has been triggered");
            m_DoorTransform.position = m_PositionClose + m_PositionOpen;
            m_IsOpening = true;
            DOTween.Kill(m_DoorTransform, "DoorTween");
            m_DoorTransform.DOMove(m_PositionOpen, 1f).SetId("DoorTween");
        }

        private void CloseDoor()
        {
            Debug.Log("Something has left the trigger");
            m_DoorTransform.position = m_PositionClose;
            m_IsOpening = false;
            DOTween.Kill(m_DoorTransform, "DoorTween");
            m_DoorTransform.DOMove(m_PositionClose, 1f).SetId("DoorTween");
        }
    }
}

