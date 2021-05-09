using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public AudioSource Audioplayer;
    
    private void OnCollisionEnter(Collision collision)
    {
        Audioplayer.Play();
        Destroy(gameObject, Audioplayer.clip.length);
    }
}
