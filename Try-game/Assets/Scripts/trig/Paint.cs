using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Video;

public class Paint : MonoBehaviour
{
    public GameObject f1;
    public GameObject f2;
    public GameObject tv;
    public AudioSource falls;
    void OnTriggerEnter()
    {
        f1.GetComponent<Rigidbody>().isKinematic = false;
        f2.GetComponent<Rigidbody>().isKinematic = false;
        
        StartCoroutine(Television());
    }

    IEnumerator Television()
    {
        yield return new WaitForSeconds(0.7f);
        falls.Play();
        yield return new WaitForSeconds(1f);
        tv.GetComponent<VideoPlayer>().enabled = true;
        this.GetComponent<BoxCollider>().enabled = false;
    }

}
