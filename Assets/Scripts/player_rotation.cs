using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_rotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {
            transform.Rotate(0, 1, 0);
        }

        if (Input.GetKey("left"))
        {
            transform.Rotate(0, -1, 0);
        }
    }
}
