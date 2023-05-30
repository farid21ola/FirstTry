using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickTarget : MonoBehaviour
{
    public GameObject kicker;
    public Rigidbody rbkicker;
    public Transform kickersPos;
    public Vector3 kickRangeV3;
    public Rigidbody ball;
    public float kickPower = 100f;

    private Rigidbody _rigidbody;
    private bool doKick;

    private void Awake()
    {
        
        _rigidbody = GetComponent<Rigidbody>();

    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //if (kickersPos.localPosition - _rigidbody.position <= kickRangeV3)
            doKick = true;
        }
    }

    private void FixedUpdate()
    {
        if (doKick == true)
        {
            ball.AddForceAtPosition(kicker.transform.forward * kickPower, kicker.transform.position);
            doKick = false;
        }
    }
}
