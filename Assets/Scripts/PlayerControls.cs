using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private float speed = 20;
    private float turnSpeed = 100;
    private float horizontalInput;
    private float verticalInput;

    void Update()
    {
    	horizontalInput = Input.GetAxis("Horizontal");
    	verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward*Time.deltaTime*speed*verticalInput);
        transform.Rotate(Vector3.up*Time.deltaTime*turnSpeed*horizontalInput);
    }
}
