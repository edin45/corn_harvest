using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class continue_game_explanation : MonoBehaviour
{
    public void continue_to_next_screen() {
        SceneManager.LoadScene(3);
    }
}
