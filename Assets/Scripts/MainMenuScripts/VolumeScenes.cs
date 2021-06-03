using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().volume = SliderAudio.PlayerVolume; //The slider will effect other scenes

    }

 
}
