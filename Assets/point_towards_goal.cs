using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point_towards_goal : MonoBehaviour
{

    public Transform goal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt( goal );
    }
}
