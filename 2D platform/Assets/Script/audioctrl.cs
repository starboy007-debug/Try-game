using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioctrl : MonoBehaviour
{
    public static audioctrl instance;
    public PlayerAudio playerAudio;
    public AudioFx audioFx;
    public Transform player;

    public bool soundOn;

    void Start()
    {
        if (instance == null)
            instance = this;
    }

    public void Shootbullet(Vector3 playerpos)
    {
        if (soundOn)
        {
            AudioSource.PlayClipAtPoint(playerAudio.firebullet, playerpos);
        }
    }

    public void enemyDestroy(Vector3 playerpos)
    {
        if (soundOn)
        {
            AudioSource.PlayClipAtPoint(playerAudio.enemyexplosion, playerpos);
        }
    }
}
