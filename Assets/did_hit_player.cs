using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class did_hit_player : MonoBehaviour
{

    public game_manager m_game_manager;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player") {
            m_game_manager.EndGame();
        }
    }
}
