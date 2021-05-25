using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false; //make sure to make the UI is transparent
    public GameObject pauseMenuUI; //make a gameobject of the pausemenu
    public AudioSource auPausing;


    void Start()
    {
        pauseMenuUI.SetActive(false); //made it false to get it transparent
        Resume();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape) && GameIsPaused == true)
        {
            auPausing.Play(); //play sound effect if the gameispaused is true
            Resume(); //if the Pausemenu = true, Resume game
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && GameIsPaused == false)
        {
            auPausing.Play(); //play sound effect if the gameispaused is false
            Pause(); //if the Pausemenu = false, pause game
        }
    }

    void Resume()
    {
        pauseMenuUI.SetActive(false); 
        Time.timeScale = 1f; //Time resume
        GameIsPaused = false; 
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true); //set the pause menu ui on false
        Time.timeScale = 0f; //Za Warudo
        GameIsPaused = true; //Gameobject is put on true

    }
}
