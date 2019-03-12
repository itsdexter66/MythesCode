using UnityEngine;

public class TeleportToPoint : MonoBehaviour { 
    // x,y,z position where you will teleport to on collision
    public Vector3 TeleportPoint;

    private void OnCollisionEnter(Collision other)
    {
        // you need a gameObject with the tag Player 
        if (other.gameObject.tag == "Player")
        {
            // transform the position of the object that touched this object
            other.transform.position = TeleportPoint;
            Destroy(this.gameObject,0.5f);
        }
    }
}
