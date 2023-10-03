using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    public GameObject LeftFlipper;
    public GameObject RightFlipper;

    //[SerializeField] private Vector3 LeftRotate = new Vector3(0f, 30f, 0f);

    // From Mathias class
    [SerializeField] private AnimationCurve animationCurve;
    private float _timer;
    private Rigidbody _rb;
    Quaternion _startRotation;
    private void Awake()
    {
        _startRotation = transform.rotation;
        _rb = GetComponent<Rigidbody>();
    }



    // Start is called before the first frame update
    void Start()
    {
        LeftFlipper = GameObject.Find("Flipper_Left_base");
        //RightFlipper = GameObject.Find("Flipper_Right_base");
    }

    // Update is called once per frame
    void Update()
    {
        // Mathias
        if (Input.GetKeyUp(KeyCode.A))
        {
            _timer = 0;
        }
        _timer += Time.deltaTime;

        if (LeftFlipper != null)
        {
            //LeftFlipper.transform.rotation = LeftRotate;
            //LeftFlipper.transform.rotation = Quaternion.FromToRotation(new Vector3(0, 0, 0), LeftRotate);
        }
        
    }


    private void FixedUpdate()
    {
        _rb.MoveRotation(_startRotation * Quaternion.Euler(0, -(animationCurve.Evaluate(_timer) * 90f), 0));
    }

    //private void OnCollisionEnter(Collision other)
    //{
    //    Debug.LogWarning($"the ball collided with {other.gameObject.name}");
    //}

}
