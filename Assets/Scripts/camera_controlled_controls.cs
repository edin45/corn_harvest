using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_controlled_controls : MonoBehaviour
{
    public Transform m_camera_parent_transform;
    public float m_speed = 1f;
    public Rigidbody m_player_rb;
    public float m_jump_strength = 2f;
    public float m_movement_smoothness = 0.125f;
    public float m_movement_builddown_factor = 0.98f;
    public float m_rotation_speed = 0.5f;

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

        if (Input.GetKey("up") || Input.GetKey("w"))
        {
            m_movement_velocity = m_camera_parent_transform.forward * m_speed;
        }

        if (Input.GetKey("right") || Input.GetKey("d"))
        {
            m_camera_parent_transform.Rotate(0f, m_rotation_speed * Time.deltaTime, 0f);
        }

        if (Input.GetKey("left") || Input.GetKey("a"))
        {
            m_camera_parent_transform.Rotate(0f, 0f - (m_rotation_speed * Time.deltaTime), 0f);
        }

        if (Input.GetKeyDown("space") && is_on_ground)
        {
            m_jump_velocity = m_camera_parent_transform.up * m_jump_strength;
        }

        Vector3 smoothed_movement = Vector3.Lerp(m_player_rb.velocity, m_movement_velocity + m_jump_velocity, m_movement_smoothness * Time.deltaTime);

        m_player_rb.velocity = smoothed_movement;

        m_jump_velocity *= m_movement_builddown_factor / Time.deltaTime;
        m_movement_velocity *= (m_movement_builddown_factor / Time.deltaTime);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "Ground")
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