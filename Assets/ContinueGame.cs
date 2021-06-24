using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueGame : MonoBehaviour
{
    public void Continuegame()
    {
        SceneManager.LoadScene("Level1"); //Play New Game
    }
}
