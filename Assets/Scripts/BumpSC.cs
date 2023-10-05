using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.UI;

public class BumpSC : MonoBehaviour
{
    public static BumpSC Instance { get; private set; }

    [SerializeField] UI UIcs;

    public int scoreValue = 100;

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        Vector3 forceDirection = collision.GetContact(0).normal;
        collision.gameObject.GetComponent<Rigidbody>().AddForce(forceDirection * 50, ForceMode.Impulse);

        UIcs.newScore(scoreValue);
    }
}
