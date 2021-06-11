using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    bool ispause = false;
    public GameObject option;
    public GameObject pausepanel;
    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if(ispause == false)
            {
                pausepanel.SetActive(true);
                ispause = true;
            }
        }
        if (Input.GetButtonDown("Cancel"))
        {
            if (ispause == true)
            {
                pausepanel.SetActive(false);
                ispause = false;
            }
        }
    }

    public void resume()
    {
        pausepanel.SetActive(false);
    }

    public void Option()
    {
        option.SetActive(true);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }


}
