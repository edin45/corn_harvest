using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody m_player_rb;
    public float m_player_movement_speed;
    public float m_movement_hardness;
    [Tooltip("The smaller the value, the faster the velocity dies down")]
    public float m_velocity_reduction_factor = 0.7f;
    public float m_jump_velocity = 120f;
    public Transform m_main_camera_transform;


    private bool m_is_on_ground = false;

    // Start is called before the first frame update
    void Start()
    {
        // rb.AddForce()

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(0,0,0);
        bool did_input_movement = false;

        if (Input.GetKey("up"))
        {
            
            movement = new Vector3(0f, 0f, (m_player_movement_speed * Time.deltaTime));
            did_input_movement = true;

        }

        if (Input.GetKey("down"))
        {

            movement = movement + new Vector3(0f, 0f, 0f - (m_player_movement_speed * Time.deltaTime));
            did_input_movement = true;

        }

        if (Input.GetKey("left"))
        {
            movement = movement + new Vector3(0f - (m_player_movement_speed * Time.deltaTime), 0f, 0f);
            did_input_movement = true;
            transform.Rotate(0f, -0.5f, 1f);
        }
        
        if (Input.GetKey("right"))
        {
            movement = movement + new Vector3((m_player_movement_speed * Time.deltaTime), 0f, 0f);
            did_input_movement = true;
            transform.Rotate(0f, 0.5f, 1f);

        }
        
        if(Input.GetKeyDown("space"))
        {
            //transform.position = transform.position + new Vector3(0f, .01f, 0f);
            m_player_rb.AddForce(new Vector3(0f, m_jump_velocity, 0f));
            m_is_on_ground = false;
            did_input_movement = true;
        }


           transform.position = Vector3.Lerp(transform.position, transform.position + movement, m_movement_hardness);
        }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Ground")
        {
            m_is_on_ground = true;
        }
    }
}
