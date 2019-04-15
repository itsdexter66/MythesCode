using UnityEngine;

public class OnCollSetActive : MonoBehaviour
{
    public string tag;
    // objects that need to be set active or false
    [SerializeField]
    private GameObject objectsSetActive,
                       objectsSetFalse;

    private void OnCollisionEnter(Collision other)
    {
        // if on collision with player, let object appear
        if (other.gameObject.tag == tag)
        {   
            objectsSetActive.SetActive(true);
            objectsSetFalse.SetActive(false);
            Destroy(this.gameObject);
        }
    }
}
