using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFunction : MonoBehaviour
{
    public AudioSource myFX;
    public AudioClip clickFx;
    public AudioClip clickCarFx;
    //public InterstitialAd ad;

    public void ViborRejMenu()
    {
        SceneManager.LoadScene("RaceRejMenu");
    }
    public void LoadSurvivRej()
    {
      //  ad.ShowAd();
        SceneManager.LoadScene("SurvLvl1");
    }
    public void ClickSound()
    {
        myFX.PlayOneShot(clickFx);
    }
    public void ClickCarSound()
    {
        myFX.PlayOneShot(clickCarFx);
    }
}
