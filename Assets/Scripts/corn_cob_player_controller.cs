using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corn_cob_player_controller : MonoBehaviour
{
    public float m_speed = 1f;
    public Rigidbody m_player_rb;
    public float m_jump_strength = 2f;
    public float m_movement_smoothness = 0.125f;
    public float m_movement_builddown_factor = 0.98f;

    private Vector3 m_movement_velocity = Vector3.zero;
    private Vector3 m_jump_velocity = Vector3.zero;
    private bool is_on_ground = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey("up"))
        {
            m_movement_velocity = new Vector3(0f,0f,m_speed * Time.deltaTime);
        }

        if (Input.GetKey("down"))
        {
            m_movement_velocity += new Vector3(0f, 0f, 0f - (m_speed * Time.deltaTime));
        }

        if (Input.GetKey("right"))
        {
            m_movement_velocity = new Vector3(m_speed * Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKey("left"))
        {
            m_movement_velocity += new Vector3(0f - (m_speed * Time.deltaTime), 0f, 0f);
        }

        if (Input.GetKeyDown("space") && is_on_ground)
        {
            m_jump_velocity = new Vector3(0f, m_jump_strength, 0f);
        }

        if(m_jump_velocity != Vector3.zero)
        {
            m_player_rb.AddForce(m_jump_velocity);
            m_jump_velocity *= m_movement_builddown_factor * Time.deltaTime;
            if(m_jump_velocity.y < 0.05f)
            {
                m_jump_velocity = Vector3.zero;
            }
        }

        Vector3 smoothed_movement = Vector3.Lerp(m_player_rb.velocity, m_movement_velocity, m_movement_smoothness);

        m_player_rb.velocity = smoothed_movement;

        if(m_movement_velocity != Vector3.zero)
        {
            m_movement_velocity *= m_movement_builddown_factor * Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Ground")
        {
            is_on_ground = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "Ground")
        {
            is_on_ground = false;
        }
    }
}
