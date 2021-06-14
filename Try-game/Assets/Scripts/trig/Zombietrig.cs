using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Zombietrig : MonoBehaviour
{
    public GameObject zombie;
    public GameObject about;

    void OnTriggerEnter()
    {
        zombie.SetActive(true);
        about.SetActive(true);
        StartCoroutine(Visib());
    }

    IEnumerator Visib()
    {
        yield return new WaitForSeconds(1f);
        about.GetComponent<Text>().text = "I need get out of here";
        yield return new WaitForSeconds(1f);
        about.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1f);
        about.GetComponent<Text>().text = "This place is weird";
        yield return new WaitForSeconds(1f);
        this.GetComponent<BoxCollider>().enabled = false;
        about.GetComponent<Text>().text = "";
    }

}
