using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class load_vid : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GetComponent<VideoPlayer>().url = System.IO.Path.Combine(Application.streamingAssetsPath, "corn_scape_intro_mp40001-0276.mp4");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
