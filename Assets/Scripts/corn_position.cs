using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corn_position : MonoBehaviour
{
    public float m_smoothing_factor = 0.125f;
    public float m_speed = 1f;
    public player_ground_check m_player_ground_check;
    public Vector3 m_ground_height = new Vector3(0,0,0);
    public bool m_is_player_on_ground = false;
    public float m_jump_strength = 2f;

    private float m_jump_velocity = 0f;
    private float m_falling_velocity = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 desired_pos = new Vector3(0, 0, 0);
        if (Input.GetKey("up"))
        {
            desired_pos = transform.position + (transform.forward * m_speed * Time.deltaTime);
        }

        if (Input.GetKey("down"))
        {
            desired_pos = transform.position - (transform.forward * m_speed * Time.deltaTime);
        }

        if (Input.GetKey("space"))
        {
            desired_pos = transform.position + (transform.up * m_jump_strength * Time.deltaTime);
        }

        //if(m_jump_velocity > 0f)
        //{

        //}

        if (desired_pos != new Vector3(0, 0, 0))
        {
            transform.position = Vector3.Lerp(transform.position, desired_pos, m_smoothing_factor);
        }

        if(!m_is_player_on_ground)
        {
            m_falling_velocity += 9.81f * Time.deltaTime;
            transform.position = transform.position - new Vector3(0f, m_falling_velocity * Time.deltaTime, 0f);
        }
        else
        {
            m_falling_velocity = 0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger");
        if (other.tag == "Ground")
        {
            m_is_player_on_ground = true;
            //transform.position = new Vector3(transform.position.x,m_ground_height.y, transform.position.z);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ground")
        {
            m_is_player_on_ground = false;
        }
    }
}
