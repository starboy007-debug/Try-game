using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Starting : MonoBehaviour
{
    public GameObject intro;
    public GameObject fadeout;
    public GameObject fadein;
    public GameObject next;
    void Start()
    {
        fadeout.SetActive(true);
        StartCoroutine(sequence());
    }

    void Update()
    {
        if (Input.GetButtonDown("Action"))
        {
          //  Debug.Log("it work");
            SceneManager.LoadScene(2);
        }
    }

    IEnumerator sequence()
    {
        yield return new WaitForSeconds(0.2f);
        fadeout.SetActive(false);
        intro.SetActive(true);
        yield return new WaitForSeconds(6f);
        next.SetActive(true);
        
        
    }

}
