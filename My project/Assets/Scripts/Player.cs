using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float turnSpeed;
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Moves the vehicle forward and backward
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
        transform.Translate(Vector3.forward * Time.deltaTime * 20);

        //turns the vehicle either left or right
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.left * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
