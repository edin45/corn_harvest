using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using UnityEngine;

public class chase_player : MonoBehaviour
{
    public float m_speed = 1f;
    public float m_smothing_value = 0.125f;
    public float m_min_distance_to_each_other = .1f;
    public float m_max_seconds_mouse = 15f;

    private GameObject _player_game_object;

    // Start is called before the first frame update
    void Start()
    {
        _player_game_object = GameObject.FindGameObjectsWithTag("Player")[0];
    }

    // Update is called once per frame
    void Update()
    {
        m_max_seconds_mouse -= Time.deltaTime;
        if (m_max_seconds_mouse < 1f)
        {
            FindObjectOfType<game_manager>().m_mice_in_existance_currently--;
            Destroy(gameObject);
        }
        float min_distance = -1;

        GameObject[] mice_list = GameObject.FindGameObjectsWithTag("mice");

        for (int i = 0;i< mice_list.Count(); i++)
        {
            float distance = Vector3.Distance(transform.position, mice_list[i].transform.position);
            if(min_distance == -1f || min_distance > distance)
            {
                min_distance = distance;
            }
        }

        Vector3 desired_pos;
        if (min_distance > m_min_distance_to_each_other || min_distance == -1f || Random.value < .2)
        {
            desired_pos = Vector3.MoveTowards(transform.position, _player_game_object.transform.position, m_speed * Time.deltaTime);
            transform.position = Vector3.Lerp(transform.position, desired_pos, m_smothing_value * Time.deltaTime);
        }
        
        
    }
}
