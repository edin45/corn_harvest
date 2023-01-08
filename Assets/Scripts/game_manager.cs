using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_manager : MonoBehaviour
{
    public GameObject m_game_over_display;
    public GameObject m_win_game_display;

    public void GameOver()
    {
        m_game_over_display.SetActive(true);
    }

    public void WinGame()
    {
        m_win_game_display.SetActive(true);
    }
}
