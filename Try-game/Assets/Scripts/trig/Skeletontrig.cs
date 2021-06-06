using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeletontrig : MonoBehaviour
{
    public GameObject skeleton;

    void OnTriggerEnter()
    {
        skeleton.SetActive(true);
    }
}
