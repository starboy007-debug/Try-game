using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobileCtrl : MonoBehaviour
{
    public GameObject player;
    Playerscipt playerscript;
    void Start()
    {
        playerscript = player.GetComponent<Playerscipt>();
    }

    public void MobileMoveLeft()
    {
        playerscript.MobileMoveLeft();
    }

    public void MobileMoveRight()
    {
        playerscript.MobileMoveRight();
    }

    public void MobileStop()
    {
        playerscript.MobileStop();
    }

    public void MobileFire()
    {
        playerscript.MobileFire();
    }

    public void MobileJump()
    {
        playerscript.MobileJump();
    }

}
