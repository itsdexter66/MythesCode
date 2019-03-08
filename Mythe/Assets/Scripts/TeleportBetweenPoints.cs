using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBetweenPoints : MonoBehaviour
{
    public Vector3 TeleportPoint;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.transform.position = TeleportPoint;
        }
    }
}
