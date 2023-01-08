using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check_if_player_entered : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            FindObjectOfType<game_manager>().WinGame();
        }
    }
}
