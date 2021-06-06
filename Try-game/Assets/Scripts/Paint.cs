using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paint : MonoBehaviour
{
    public GameObject f1;
    public GameObject f2;

    void OnTriggerEnter()
    {
        f1.GetComponent<Rigidbody>().isKinematic = false;
        f2.GetComponent<Rigidbody>().isKinematic = false;
        this.GetComponent<BoxCollider>().enabled = false;
    }
}
