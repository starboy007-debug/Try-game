using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public Transform Optionpanel;


    void Awake()
    {
        Optionpanel.gameObject.SetActive(false);
    }
    public void playgame()
    {
        SceneManager.LoadScene("GamePlay0");
    }

    public void ChooseOption()
    {
        Optionpanel.gameObject.SetActive(true);
    }

    public void backmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
