using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishSpawnner : MonoBehaviour
{
    public GameObject fish;
    public float spawnDelay;
    bool canspawn;
    void Start()
    {
        canspawn = true;
    }

   
    void Update()
    {
        if (canspawn)
            StartCoroutine("Spawnfish");
            
    }

    IEnumerator Spawnfish()
    {
        Instantiate(fish, transform.position, Quaternion.identity);
        canspawn = false;
        yield return new WaitForSeconds(spawnDelay);
        canspawn = true;
    }
}
