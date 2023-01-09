using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_manager : MonoBehaviour
{
    public GameObject m_game_over_display;
    public GameObject m_win_game_display;

    public int m_mice_in_existance_currently = 0;

    public void GameOver()
    {
        m_game_over_display.SetActive(true);
    }

    public void WinGame()
    {
        m_win_game_display.SetActive(true);
        GameObject[] mice = GameObject.FindGameObjectsWithTag("mice");
        for (int i = 0; i < mice.Length; i++)
        {
            Destroy(mice[i]);
        }
        FindObjectOfType<mice_spawner>().enabled = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
