using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerScore : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Collectable")
        {
            target.gameObject.SetActive(false);
            GamePlayController.instance.IncrementScore();
        }
        if(target.tag == "Enemy")
        {
            GamePlayController.instance.DecrementScore();
            
        }

        if(target.tag == "Water")
        {
            SceneManager.LoadScene("GamePlay0");
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            GamePlayController.instance.DecrementScore();
            collision.gameObject.SetActive(false);
        }
    }

}
