using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class BumpSC : MonoBehaviour
{
    //public float bumpForce = 10f;

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Ball"))
    //    {
    //        Rigidbody ballRb = other.GetComponent<Rigidbody>();

    //        if (ballRb != null)
    //        {
    //            // Force direction away from Bumper
    //            //Vector3 forceDirection = (other.transform.position - transform.position).normalized;
    //            Vector3 forceDirection = -other.transform.forward;
    //            Debug.Log("forceDirection: " +  forceDirection);

    //            // Apply force to ball
    //            ballRb.AddForce(forceDirection * bumpForce, ForceMode.Impulse);
    //        }
    //    }
    //}

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        Vector3 forceDirection = collision.GetContact(0).normal;
        collision.gameObject.GetComponent<Rigidbody>().AddForce(forceDirection * 50, ForceMode.Impulse);
    }


    //public int bumperForce = 800;
    ////private GameObject ball;

    ////void Start()
    ////{
    ////    ball = GameObject.FindGameObjectWithTag("Ball");
    ////}

    //public void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.name == "Ball")
    //    {
    //        //Vector3 bounceDirection = collision.GetContact(0).normal;
    //        //collison.GetComponent<Rigidbody>().AddExplosionForce(bumperForce, transform.position, 1);
    //        collision.gameObject.GetComponent<Rigidbody>().AddExplosionForce(bumperForce, transform.position, 1);

    //    }
    //}
}
