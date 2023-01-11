using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Varables
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardinput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //This is where we get palyer input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardinput = Input.GetAxis("Vertical");

        // Moves  car forward based on the vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardinput);
        // Rotates the car based on horizontal input 
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        
    }  
}
