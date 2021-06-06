using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Lapofftrig : MonoBehaviour
{
    public GameObject laptop;

    void OnTriggerEnter()
    {
        laptop.GetComponent<VideoPlayer>().enabled = false;
    }
}
