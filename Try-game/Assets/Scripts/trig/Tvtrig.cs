using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Tvtrig : MonoBehaviour
{
    public GameObject tv;
    void OnTriggerEnter()
    {
        if (Input.GetButtonDown("Action"))
        {
            tv.GetComponent<VideoPlayer>().enabled = false;
        }
    }
}
