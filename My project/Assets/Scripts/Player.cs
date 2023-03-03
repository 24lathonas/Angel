using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 12.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

            if(Input.GetKey(KeyCode.LeftArrow))
                transform.Rotate(0, -90 * Time.deltaTime, 0);
            if(Input.GetKey(KeyCode.RightArrow))
                transform.Rotate(0, 90 * Time.deltaTime, 0);
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

            if(Input.GetKey(KeyCode.LeftArrow))
                transform.Rotate(0, -90 * Time.deltaTime, 0);
            if(Input.GetKey(KeyCode.RightArrow))
                transform.Rotate(0, 90 * Time.deltaTime, 0);
        }
    }
}
