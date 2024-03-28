using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Button_Controller : MonoBehaviour
{
    public VideoPlayer player; 
    // Start is called before the first frame update
    void Start()
    {
        player.Stop();
    }

    // Update is called once per frame
    public void VideoPlay()
    {
        player.Play();
    }

    public void VideoStop()
    {
        player.Stop();
    }
}
