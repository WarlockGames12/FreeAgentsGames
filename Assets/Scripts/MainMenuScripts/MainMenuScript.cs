using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void NewGame()
    {
        SceneManager.LoadScene("Dialogue"); //Play New Game
    }


    public void ExitGame()
    {
        Debug.Log("This thing works if you wanna know"); //Quit Game
        Application.Quit();
    }
}
