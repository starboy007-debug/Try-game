using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ExitDoor : MonoBehaviour
{
    public GameObject about;
   void OnTriggerEnter()
    {
        about.GetComponent<Text>().text = "Door is locked"; 
    }
    void OnTriggerExit()
    {
        about.GetComponent<Text>().text = "";
    }
}
