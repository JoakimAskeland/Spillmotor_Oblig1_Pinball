using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public float forceMultiplier = 10f;
    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(UnityEngine.Collision other)
    {
        Debug.LogWarning($"the ball collided with {other.gameObject.name}");

        if (other.relativeVelocity.magnitude > 1)
        {
            Vector3 forceDirection = -other.contacts[0].normal;

            rb.AddForce(forceDirection * forceMultiplier * other.relativeVelocity.magnitude, ForceMode.Impulse);
        }

    }

    //private void OnCollisionEnter(Collision other)
    //{
    //    Debug.LogWarning($"this object collider with {other.gameObject.name}");

    //    //if (collision.relativeVelocity.magnitude > 1) 
    //    //{
    //    //    Vector3 forceDirection = -collision.contacts[0].normal;
    //    //}
    //}
}
