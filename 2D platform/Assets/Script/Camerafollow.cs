using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public Transform player;
    public float yoffset;

    void Update()
    {
        // only x
        //transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
        // x and y
        transform.position = new Vector3(player.position.x, player.position.y+yoffset, transform.position.z);
        


    }
}
