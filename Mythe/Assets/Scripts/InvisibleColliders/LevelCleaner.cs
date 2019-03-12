using UnityEngine;

public class LevelCleaner : MonoBehaviour
{
    // assign object that needs to be destroyed
    public GameObject objects;

    private void OnCollisionEnter(Collision other)
    {
        // if on collision with player, destroy the assigned object and itself
        if (other.gameObject.tag == "Player")
        {
            Destroy(objects);
            Destroy(this.gameObject);
        }
    }
}
