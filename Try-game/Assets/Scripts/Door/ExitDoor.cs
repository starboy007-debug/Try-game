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
        if(CardPickUp.isgo == true)
        {
            fadein.SetActive(true);
            StartCoroutine(Loadtomenu());
            
        }
        else
        {
            about.GetComponent<Text>().text = "Door is locked";
        }

    }

    IEnumerator Loadtomenu()
    {
        yield return new WaitForSeconds(0.9f);
        SceneManager.LoadScene(0);
    }
    void OnTriggerExit()
    {
        about.GetComponent<Text>().text = "";
    }
}
