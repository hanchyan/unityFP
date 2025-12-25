using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 11.0f;
    public float turnSpeed = 10.0f;
    public float horizontalInput;
    public float forwardInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // move vehicle forward
        // transform.Translate(0, 0, 1);
        // below line is same as above...
        transform.Translate(Vector3.forward* Time.deltaTime* speed*forwardInput);
        // transform.Translate(Vector3.forward* Time.deltaTime* speed);
        // transform.Translate(Vector3.right* Time.deltaTime* turnSpeed*horizontalInput);
        transform.Rotate(Vector3.up, Time.deltaTime* turnSpeed*horizontalInput);
    }
}
