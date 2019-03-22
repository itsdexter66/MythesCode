using UnityEngine;

public class OnCollSetActive : MonoBehaviour
{
    [SerializeField]
    private GameObject objectsSetActive,
                       objectsSetFalse;

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
