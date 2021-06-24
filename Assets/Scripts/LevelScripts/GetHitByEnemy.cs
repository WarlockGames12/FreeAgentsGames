using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class GetHitByEnemy : MonoBehaviour
{
    public Camera DestroyCamera;
    public AudioClip PlayClip;
    public static bool GameOver = false;
    public GameObject GameOverScreen;
    public GameObject Player;
    public HealthBar healthbar;
    public int maxHealth = 100;
    public int currentHealth;
   

    void Start()
    {
        GameOverScreen.SetActive(false);
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    void OnCollisionEnter(Collision collision)
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = PlayClip;


        switch (collision.gameObject.tag)
        {
            case "Goonki":
                TakeDamage(5);
                audio.Play();
                break;

            case "Krillon":
                TakeDamage(20);
                audio.Play();
                break;

            case "Nomu":
                TakeDamage(30);
                audio.Play();
                break;

            default:
                //dit doet niks
                break;
        }

        if (currentHealth != 0) { return; }

        audio.Play();
        GameOverScreen.SetActive(true);
        Destroy(DestroyCamera);
        Destroy(Player);
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
    }
}
