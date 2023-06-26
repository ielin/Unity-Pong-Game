using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic backgroundMusic;

    private void Awake()
    {
        if(backgroundMusic == null)
        {
            backgroundMusic = this;
            DontDestroyOnLoad(backgroundMusic);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PauseMusic()
    {
        if(PauseMenu.gameIsPaused)
        {
            backgroundMusic.GetComponent<AudioSource>().Pause();
        }
        else
        {
            backgroundMusic.GetComponent<AudioSource>().Play();
        }
    }

    public void CreditsMusic()
    {
        if (Credits.creditsOpen)
        {
            backgroundMusic.GetComponent<AudioSource>().volume = 0.3f;
        }
        else
        {
            backgroundMusic.GetComponent<AudioSource>().volume = 1f;
        }
    }

}
