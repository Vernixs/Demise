using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public GameObject teleportTarget;
    public GameObject thePlayer;

    void onTriggerEnter(Collider other)
    {
        thePlayer.transform.position = teleportTarget.transform.position;
        Debug.Log("Touched but no tp");
    }
}
