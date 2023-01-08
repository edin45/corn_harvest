using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_manager : MonoBehaviour
{
    public GameObject m_game_over_display;

    public void EndGame()
    {
        m_game_over_display.SetActive(true);
    }
}
