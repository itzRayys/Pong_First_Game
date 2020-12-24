using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public void Start()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("volumePref");
    }
    public void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void quitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }


    public Slider volumeSlider;
    private float soundFloat;

    public void setPlayerPref()
    {
        soundFloat = volumeSlider.value;
        PlayerPrefs.SetFloat("volumePref", soundFloat);
        volumeSlider.value = soundFloat;
    }
}
