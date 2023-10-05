using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    public GameObject LeftFlipper;
    public GameObject RightFlipper;

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
    }

    // Update is called once per frame
    void Update()
    {
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
        _rbLeft.MoveRotation(_startRotationLeft * Quaternion.Euler(0, -(animationCurve.Evaluate(_timerLeft) * 90f), 0));

        _rbRight.MoveRotation(_startRotationRight * Quaternion.Euler(0, (animationCurve.Evaluate(_timerRight) * 90f), 0));
    }
}
