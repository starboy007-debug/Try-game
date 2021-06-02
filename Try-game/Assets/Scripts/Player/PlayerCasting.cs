using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour
{
    public static float distanceFromTarget;
    public float toTarget;
    public string hitTag;
    void Update()
    {
        RaycastHit Hit;
        // Debug.DrawRay(transform.position,direction * Maxdist,Color.green);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {
            toTarget = Hit.distance;
            distanceFromTarget = toTarget;
            hitTag = Hit.transform.tag;
        }
    }
}