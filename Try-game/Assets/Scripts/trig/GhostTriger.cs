using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostTriger : MonoBehaviour
{
    public GameObject ghostclone;

    void OnTriggerEnter()
    {
        ghostclone.SetActive(true);
        StartCoroutine(ghostfade());
    }

    IEnumerator ghostfade()
    {
        yield return new WaitForSeconds(0.2f);
        this.GetComponent<BoxCollider>().enabled = false;
        yield return new WaitForSeconds(2.2f);
        ghostclone.SetActive(false);
    }

}
