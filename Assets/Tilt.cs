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
        currentRotation = GetComponent<Transform>().eulerAngles;
        
        if ((Input.GetAxis("Mouse X") > .2) && (currentRotation.z <= 10 || currentRotation.z >= 348))
        {
            transform.Rotate(0, 0, speed * 1);           
        }
        if ((Input.GetAxis("Mouse X") < -.2) && (currentRotation.z >= 349 || currentRotation.z <= 11))
        {
            transform.Rotate(0, 0, speed * -1);           
        }
        if ((Input.GetAxis("Mouse Y") > .2) && (currentRotation.x <= 10 || currentRotation.x >= 348))
        {
            transform.Rotate(speed * 1, 0, 0);           
        }
        if ((Input.GetAxis("Mouse Y") < -.2) && (currentRotation.x >= 349 || currentRotation.x <= 11))
        {
            transform.Rotate(speed * -1, 0, 0);           
        }
    }
}
