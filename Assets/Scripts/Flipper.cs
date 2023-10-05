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

    // Left flipper
    private float _timerLeft;
    private Rigidbody _rbLeft;
    Quaternion _startRotationLeft;

    // Right flipper
    private float _timerRight;
    private Rigidbody _rbRight;
    Quaternion _startRotationRight;


    private void Awake()
    {
        LeftFlipper = GameObject.Find("Flipper_Left_base");
        _startRotationLeft = LeftFlipper.transform.rotation;
        _rbLeft = LeftFlipper.GetComponent<Rigidbody>();

        RightFlipper = GameObject.Find("Flipper_Right_base");
        _startRotationRight = RightFlipper.transform.rotation;
        _rbRight = RightFlipper.GetComponent<Rigidbody>();

        //_rb = LeftFlipper.GetComponent<Rigidbody>();

        //_startRotation = transform.rotation; // Funker
        //_rb = GetComponent<Rigidbody>(); // Funker
    }



    // Start is called before the first frame update
    void Start()
    {
        //LeftFlipper = GameObject.Find("Flipper_Left_base"); // Funker
        //RightFlipper = GameObject.Find("Flipper_Right_base");
    }

    // Update is called once per frame
    void Update()
    {
        // Mathias // Funker
        //if (Input.GetKeyUp(KeyCode.A))
        //{
        //    _timer = 0;
        //}
        //_timer += Time.deltaTime;

        //if (LeftFlipper != null)
        //{
        //    //LeftFlipper.transform.rotation = LeftRotate;
        //    //LeftFlipper.transform.rotation = Quaternion.FromToRotation(new Vector3(0, 0, 0), LeftRotate);
        //}

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            _timerLeft = 0;
        }
        _timerLeft += Time.deltaTime;

        if (Input.GetKeyUp(KeyCode.RightArrow))
        { 
            _timerRight = 0; 
        }
        _timerRight += Time.deltaTime;
        
    }


    private void FixedUpdate()
    {
        //_rb.MoveRotation(_startRotation * Quaternion.Euler(0, -(animationCurve.Evaluate(_timer) * 90f), 0)); // Funker

        _rbLeft.MoveRotation(_startRotationLeft * Quaternion.Euler(0, -(animationCurve.Evaluate(_timerLeft) * 90f), 0));

        _rbRight.MoveRotation(_startRotationRight * Quaternion.Euler(0, (animationCurve.Evaluate(_timerRight) * 90f), 0));
    }

    //private void OnCollisionEnter(Collision other)
    //{
    //    Debug.LogWarning($"the ball collided with {other.gameObject.name}");
    //}

}
