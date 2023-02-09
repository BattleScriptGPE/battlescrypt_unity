using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuGestion : MonoBehaviour
{
    public GameObject musicController;
    private AudioSource source;

    public void PlayPauseButton()
    { 
        source = musicController.GetComponent<AudioSource>();
        if (!source.isPlaying)
        {
            source.Play();
        }
        else
        {
            source.Pause();
        }
    }
    
}
