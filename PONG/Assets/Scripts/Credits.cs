using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public GameObject creditsUI;
    public BackgroundMusic backgroundMusic;
    public static bool creditsOpen = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            creditsUI.SetActive(false);
            creditsOpen = false;
            backgroundMusic.CreditsMusic();
        }
    }

    public void OpenCredits()
    {
        creditsUI.SetActive(true);
        creditsOpen = true;
        backgroundMusic.CreditsMusic();
    }
}
