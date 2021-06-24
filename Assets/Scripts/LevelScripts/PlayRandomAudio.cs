using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRandomAudio : MonoBehaviour
{
    public AudioSource _as;
    public AudioClip[] audioClipArray;
    

    void Awake()
    {
        _as = GetComponent<AudioSource>();
    }

    

    void Update()
    {
        IEnumerator NumberGen()
        {
            while (true)
            {
                _as.clip = audioClipArray[Random.Range(0, audioClipArray.Length)];
                _as.PlayOneShot(_as.clip);
                yield return new WaitForSeconds(15);
            }
        }
        StartCoroutine(NumberGen());
    }
    
}
