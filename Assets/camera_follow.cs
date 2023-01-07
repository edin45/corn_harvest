using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform m_player_transform;

    public float m_snapping_speed;

    public Vector3 m_camera_offset;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 smooth_pos = Vector3.Lerp(transform.position, m_player_transform.position + m_camera_offset, m_snapping_speed);

        transform.position = smooth_pos;

        transform.LookAt(m_player_transform);
    }
}
