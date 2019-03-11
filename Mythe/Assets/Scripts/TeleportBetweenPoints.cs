using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBetweenPoints : MonoBehaviour { 
    // x,y,z position where you will be teleported to on collision
    public Vector3 TeleportPoint;

    private void OnCollisionEnter(Collision other)
    {
        // you need a gameObject with the tag Player 
        if (other.gameObject.tag == "Player")
        {
            // transform the position of the object that touched this object
            other.transform.position = TeleportPoint;
        }
    }
}
