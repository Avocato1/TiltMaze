using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour
{
    public float speed = 1f;
    
    public Vector3 currentRotation;
    private void Update()
    {
        if (Input.GetAxis("Mouse X") > .2)
        {
            transform.Rotate(0, 0, speed * -1);           
        }
        if (Input.GetAxis("Mouse X") < -.2)
        {
            transform.Rotate(0, 0, speed * 1);           
        }
        if (Input.GetAxis("Mouse Y") > .2)
        {
            transform.Rotate(speed * 1, 0, 0);           
        }
        if (Input.GetAxis("Mouse Y") < -.2)
        {
            transform.Rotate(speed * -1, 0, 0);           
        }
    }
}
