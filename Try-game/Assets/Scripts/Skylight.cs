using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skylight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Changelight());
    }

    IEnumerator Changelight()
    {
        yield return new WaitForSeconds(5f);
        RenderSettings.ambientIntensity = 1f;
    }
}
