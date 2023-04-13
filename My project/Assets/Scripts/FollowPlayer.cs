using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Camera Camera1;

    // Start is called before the first frame update
    void Start()
    {
        Camera1 = Camera.main;

        Camera1.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
   
    }
}
