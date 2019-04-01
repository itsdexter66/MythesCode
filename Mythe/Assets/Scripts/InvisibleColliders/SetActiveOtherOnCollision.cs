using UnityEngine;

public class SetActiveOtherOnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        // Destroy other object on collision with the tag Player
        if (other.gameObject.tag == "Player")
        {
            //Destroy(other.gameObject);
            Application.LoadLevel("DeathScene");
        }
    }
}
