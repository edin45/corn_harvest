using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class check_player_distances : MonoBehaviour
{

    public Transform m_tractor_tranform;
    public Transform m_goal_transform;

    public TextMeshProUGUI m_tractor_distance_text;
    public TextMeshProUGUI m_goal_distance_text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance_to_tractor = Vector3.Distance(transform.position, m_tractor_tranform.position);
        float distance_to_goal = Vector3.Distance(transform.position, m_goal_transform.position);

        m_tractor_distance_text.text = Math.Round(distance_to_tractor, 2).ToString() + "m";
        m_goal_distance_text.text = Math.Round(distance_to_goal,2).ToString() + "m";

    }
}
