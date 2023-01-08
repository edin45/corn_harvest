using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsPlayer : MonoBehaviour
{
    public Transform m_target_transform;
    public float m_speed;

    private bool _did_hit_goal = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!_did_hit_goal)
        {
            Vector3 target_position = Vector3.MoveTowards(transform.position, m_target_transform.position, m_speed * Time.deltaTime);

            transform.position = new Vector3(target_position.x, transform.position.y, target_position.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "tractor_goal")
        {
            _did_hit_goal= true;
            GetComponent<did_hit_player>().enabled = false;

        }
    }


}
