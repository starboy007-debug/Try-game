using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
