using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuButtonsScript : MonoBehaviour
{
    
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu"); //Go back to the main menu
    }

    public void ExitGame()
    {
        Debug.Log("This thing works if you wanna know"); //Quit Game
        Application.Quit();
    }
}
