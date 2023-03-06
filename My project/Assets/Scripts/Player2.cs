using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float speed = 12.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

            if(Input.GetKey(KeyCode.A))
                transform.Rotate(0, -90 * Time.deltaTime, 0);
            if(Input.GetKey(KeyCode.D))
                transform.Rotate(0, 90 * Time.deltaTime, 0);
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

            if(Input.GetKey(KeyCode.A))
                transform.Rotate(0, -90 * Time.deltaTime, 0);
            if(Input.GetKey(KeyCode.D))
                transform.Rotate(0, 90 * Time.deltaTime, 0);
        }
    }
}
