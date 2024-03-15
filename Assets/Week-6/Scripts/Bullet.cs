using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float m_Speed;

    private void Awake()
    {
        Destroy(gameObject, 10f);
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * m_Speed * Time.fixedDeltaTime);
    }

    public void Damage()
    {
        Debug.Log("Player was damaged!");
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (other.transform.tag == "Bullet") Damage();
    }
}
