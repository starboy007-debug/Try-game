using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour
{
    public bool gamePaused = false;
    public GameObject option;
    public GameObject pauseMenu;
    public AudioSource pauseaudio;

    void Update()
    {
        
        if (Input.GetButtonDown("Cancel"))
        {
            if (gamePaused == false)
            {
                pauseaudio.Play();
                Time.timeScale = 0;
                gamePaused = true;
                Cursor.visible = true;
                pauseMenu.SetActive(true);
               
            }
            else
            {
                pauseMenu.SetActive(false);
                pauseaudio.Play();
                Cursor.visible = false;
                gamePaused = false;
                Time.timeScale = 1;
            }
        }
        if (Input.GetButtonDown("Back"))
        {
            option.SetActive(false);
            Cursor.visible = true;
        }
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        pauseaudio.Play();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
    }

    public void optionLevel()
    {
        option.SetActive(true);
        pauseaudio.Play();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
    }

    public void QuitToMenu()
    {
        pauseMenu.SetActive(false);
        pauseaudio.Play();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

}
