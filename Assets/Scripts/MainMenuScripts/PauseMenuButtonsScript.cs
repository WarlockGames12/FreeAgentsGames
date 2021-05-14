using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuButtonsScript : MonoBehaviour
{
   
   

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Debug.Log("This thing works if you wanna know");
        Application.Quit();
    }
}
