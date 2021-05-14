using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour
{
    public GameObject GameOverScreen;
    public bool GameOver = false;
    public AudioSource PlayerDeath;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("RespawnGround"))
        {
            GameOverScreen.SetActive(true);
            GameOver = true;
            PlayerDeath.Play();
            Destroy(gameObject, PlayerDeath.clip.length);
        }
    }
}
