using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_scripts : MonoBehaviour
{

    public static void start_game()
    {
        SceneManager.LoadScene("Intro_Cutscene");

    }

    public static void quit_game()
    {
        Application.Quit();
    }
}
