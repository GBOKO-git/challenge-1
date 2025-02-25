using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    // create my first private variable
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // this is where we get player input
    horizontalInput = Input.GetAxis("Horizontal");
    forwardInput = Input.GetAxis("Vertical");
        // Move the vehicle forward
    transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // we Turn the vehicle forward
    transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);
    }
}
