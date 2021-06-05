using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Sequencing : MonoBehaviour
{
    public GameObject box;
    public GameObject torch;
    public GameObject card;
    public GameObject about;
    public GameObject fps;
    public GameObject fadein;
    public GameObject fadeout;
    public GameObject pizza;
    public GameObject pizza1;
    public GameObject Exitdoor;

    void Start()
    {
        fadeout.SetActive(true);
        pizza1.SetActive(true);
        StartCoroutine(Mam());
    }

    IEnumerator Mam()
    {
        fps.GetComponent<FirstPersonController>().enabled = false;
        yield return new WaitForSeconds(1f);
        fadeout.SetActive(false);
        yield return new WaitForSeconds(2f);
        about.GetComponent<Text>().text = "Hello mam I am here to deliver your pizza";
        yield return new WaitForSeconds(2f);
        about.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(2.0f);
        about.GetComponent<Text>().text = "I think she is busy";
        yield return new WaitForSeconds(2f);
        about.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(2.0f);
        about.GetComponent<Text>().text = "I should just drop pizza on table and leave";
        yield return new WaitForSeconds(2f);
        about.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(0.5f);
      //  fps.GetComponent<FirstPersonController>().enabled = false;
        yield return new WaitForSeconds(1f);
        fps.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(10f);
        pizza1.SetActive(false);
        pizza.SetActive(true);
        fadein.SetActive(true);
        yield return new WaitForSeconds(1f);
        fadein.SetActive(false);
        fadeout.SetActive(true);
        yield return new WaitForSeconds(1f);
        fps.GetComponent<Animator>().enabled = false;
        fadeout.SetActive(false);
        fps.GetComponent<FirstPersonController>().enabled = true;
        Exitdoor.GetComponent<BoxCollider>().enabled = true;

    }

    void OnBox()
    {
        box.GetComponent<BoxCollider>().enabled = true;
    }

}
