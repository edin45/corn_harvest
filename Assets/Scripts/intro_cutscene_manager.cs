using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class intro_cutscene_manager : MonoBehaviour
{
    VideoPlayer video;

    void Awake()
    {
        video = FindObjectOfType < VideoPlayer>();
        video.Play();
        video.loopPointReached += CheckOver;


    }


    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadScene(2);//the scene that you want to load after the video has ended.
    }
}
