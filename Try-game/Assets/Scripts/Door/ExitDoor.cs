using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ExitDoor : MonoBehaviour
{
    public GameObject about;
    public GameObject fadein;
   void OnTriggerEnter()
    {
        if(Cuter.iscut == true)
        {
            fadein.SetActive(true);
            SceneManager.LoadScene(0);
        }
        else
        {
            about.GetComponent<Text>().text = "Door is locked";
        }

    }
    void OnTriggerExit()
    {
        about.GetComponent<Text>().text = "";
    }
}
