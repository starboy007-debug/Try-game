using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mintrig : MonoBehaviour
{
    public GameObject sphere;
    void OnTriggerEnter()
    {
        StartCoroutine(Mint());
    }

    IEnumerator Mint()
    {
        yield return new WaitForSeconds(1f);
        sphere.SetActive(true);
        yield return new WaitForSeconds(2f);
        sphere.SetActive(false);
    }

}
