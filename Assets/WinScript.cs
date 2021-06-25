using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    public static bool WinScreen = false;
    public GameObject YouWinScreen;

    void Start()
    {
        YouWinScreen.SetActive(false);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Win"))
        {
            Debug.Log("Does is work?");
            YouWinScreen.SetActive(true);
            WinScreen = true;
        }
    }

    
}
