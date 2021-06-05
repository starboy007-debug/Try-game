using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Read : MonoBehaviour
{
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject Paper;

    void OnTriggerEnter()
    {
        ActionDisplay.SetActive(true);
        ActionText.SetActive(true);
        if (Input.GetButtonDown("Action")){
            ActionDisplay.SetActive(false);
            ActionText.SetActive(false);
            Paper.SetActive(true);
        }

    }

    void OnTriggerExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        if (Input.GetButtonDown("Action"))
        {
            Paper.SetActive(false);
        }
    }

}
