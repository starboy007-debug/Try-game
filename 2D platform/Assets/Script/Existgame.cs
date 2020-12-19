using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Existgame : MonoBehaviour
{
    public float delaytime;
    public Transform player;
    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Player")
        {
            Invoke("nextlevel", delaytime);
        }
    }

    void nextlevel()
    {
         player.position = new Vector3(65f, 0, 0);
        //SceneManager.LoadScene("122");
    }
}
