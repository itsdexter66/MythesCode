using UnityEngine;

public class OnCollSetActive : MonoBehaviour
{
    // objects that need to be set active or false
    [SerializeField]
    private GameObject objectsSetActive,
                       objectsSetFalse;

    // booleans to tell if the objects needs to be set active or false
    [SerializeField]
    private bool activityObjectTrue,
                 activityObjectFalse;

    private void OnCollisionEnter(Collision other)
    {
        // if on collision with player, let object appear
        if (other.gameObject.tag == "Player")
        {
            if (activityObjectTrue == true )
            {
                objectsSetActive.SetActive(true);
            }
            if (activityObjectFalse == true)
            {
                objectsSetFalse.SetActive(false);
            }
            Destroy(this.gameObject);
        }
    }
}
