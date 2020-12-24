using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Sound
{
    public string name; 

    public AudioClip clip;

    

    [Range(.1f, 3f)]
    public float pitch;

    [HideInInspector]
    public AudioSource source;
}
