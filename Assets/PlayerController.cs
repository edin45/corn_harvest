using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody m_player_rb;
    public float m_player_movement_speed;
    public float m_movement_hardness;

    // Start is called before the first frame update
    void Start()
    {
        // rb.AddForce()

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(0,0,0);
        bool did_move = false;

        if (Input.GetKey("up"))
        {
            
            movement = new Vector3(0f, 0f, m_player_movement_speed * Time.deltaTime);
            did_move = true;

        }else if(Input.GetKey("right"))
        {
            movement = new Vector3(0f - (m_player_movement_speed * Time.deltaTime), 0f, 0f);
            did_move = true;
        }

        transform.position = Vector3.Lerp(transform.position, transform.position + movement, m_movement_hardness * Time.deltaTime);
    }
}
