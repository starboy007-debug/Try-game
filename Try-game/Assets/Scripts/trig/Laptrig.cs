using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Laptrig : MonoBehaviour
{
    public GameObject laptop;

    void OnTriggerEnter()
    {
        laptop.GetComponent<VideoPlayer>().enabled = true;
        StartCoroutine(offff());
    }

    IEnumerator offff()
    {
        yield return new WaitForSeconds(1f);
        this.GetComponent<BoxCollider>().enabled = false;
    }

}
