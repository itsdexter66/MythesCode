using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOtherOnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        // Destoy other object on collision with the tag Player
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
        }
    }
}
