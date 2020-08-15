using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenController : MonoBehaviour
{
    //Screen GameObjects:
    public GameObject StartScreen;
    public GameObject PresetScreen;
    public GameObject BueroScreen;
    public GameObject GymScreen;
    public GameObject NewPresetScreen;

    public void BueroButtonClicked()
    {
        PresetScreen.SetActive(false);
        BueroScreen.SetActive(true);
    }
    public void GymButtonClicked()
    {
        PresetScreen.SetActive(false);
        GymScreen.SetActive(true);
    }
    public void NewPresetButtonClicked()
    {
        PresetScreen.SetActive(false);
        NewPresetScreen.SetActive(true);
    }

    //Wait for Logo to fuck off:
    IEnumerator StartScreenWait()
    {
        yield return new WaitForSeconds(0);
        StartScreen.SetActive(false);
        PresetScreen.SetActive(true);
    }
    void Start()
    {
        StartScreen.SetActive(true);
        PresetScreen.SetActive(false);
        StartCoroutine(StartScreenWait());
    }

    void Update()
    {
       
    }
}
