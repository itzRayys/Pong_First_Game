using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class VolumeControl : MonoBehaviour
{
    private float soundVolume;
    private AudioSource audioS;
    void Start()
    {
        
    }

    
    void Update()
    {
        audioS.volume = soundVolume;
    }
    public void changeVolume(float vol)
    {
        audioS.volume = vol;
    }
}
