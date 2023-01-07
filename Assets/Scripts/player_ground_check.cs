using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_ground_check : MonoBehaviour
{

    public corn_position m_corn_position;
    //public bool m_is_player_on_ground = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Ground")
        {
            Debug.Log("Ground Hit");
            m_corn_position.m_is_player_on_ground = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "Ground")
        {
            m_corn_position.m_is_player_on_ground = false;
        }
    }
}
