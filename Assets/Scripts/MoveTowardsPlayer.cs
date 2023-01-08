using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsPlayer : MonoBehaviour
{
    public Transform m_target_transform;
    public float m_speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target_position = Vector3.MoveTowards(transform.position, m_target_transform.position, m_speed * Time.deltaTime);

        transform.position = new Vector3(target_position.x, transform.position.y, target_position.z);
    }
}
