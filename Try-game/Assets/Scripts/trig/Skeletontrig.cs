using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeletontrig : MonoBehaviour
{
    public GameObject skeleton;
    public GameObject ghosttrig2;

    void OnTriggerEnter()
    {
        skeleton.SetActive(true);
        ghosttrig2.SetActive(true);
        StartCoroutine(fadera());
    }

    IEnumerator fadera()
    {
        yield return new WaitForSeconds(1f);
        ghosttrig2.SetActive(false);
    }
}
