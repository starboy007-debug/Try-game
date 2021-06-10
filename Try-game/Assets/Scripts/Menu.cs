using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{

    public GameObject option;
    public AudioSource btn;

    void Update()
    {
        if (Input.GetButtonDown("Back"))
        {
            option.SetActive(false);
            btn.Play();
        }
    }
    public void Option()
    {
        option.SetActive(true);
        btn.Play();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        btn.Play();
    }

    public void Band()
    {
        Application.Quit();
        btn.Play();
    }

}
