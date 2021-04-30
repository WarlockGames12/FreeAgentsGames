using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void NewGame()
    {
        SceneManager.LoadScene("Level1");
    }


    public void ExitGame()
    {
        Debug.Log("This thing works if you wanna know");
        Application.Quit();
    }
}
