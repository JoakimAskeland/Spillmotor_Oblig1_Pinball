using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (other.gameObject.name == "Wall-Bottom")
        {
            Debug.Log("Game Over. plz stop");
            //Application.Quit();
            SceneManager.LoadScene(0);
        }
    }
}
