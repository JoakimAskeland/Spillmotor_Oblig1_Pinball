using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    public GameObject LeftFlipper;
    public GameObject RightFlipper;

    [SerializeField] private Vector3 LeftRotate = new Vector3(0f, 30f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        LeftFlipper = GameObject.Find("Flipper_Left_base");
        //RightFlipper = GameObject.Find("Flipper_Right_base");
    }

    // Update is called once per frame
    void Update()
    {
        if (LeftFlipper != null)
        {
            //LeftFlipper.transform.rotation = LeftRotate;
            LeftFlipper.transform.rotation = Quaternion.FromToRotation(new Vector3(0, 0, 0), LeftRotate);
        }
        
    }
}
