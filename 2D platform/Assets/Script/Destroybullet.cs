using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroybullet : MonoBehaviour
{
    public float delay;
    public GameObject fireeffect;
    void Start()
    {
        Destroy(gameObject, delay);
       Instantiate(fireeffect, transform.position, Quaternion.identity);
    }
}
