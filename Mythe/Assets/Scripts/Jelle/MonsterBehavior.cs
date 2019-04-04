using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBehavior : MonoBehaviour
{
    [SerializeField]
    float movementSpeed = 6;
    public LayerMask targetLayer;
    float detectRange;
    private Vector3 dir;
    Transform target;
    PlayerBehavior playerReference;
    CameraScript camScriptRef;
    int leapCount;
    bool leapOnce = true;
    //public float destroyableDistance = 2;
    // Start is called before the first frame update

    //List<GameObject> destroyables = new List<GameObject>();
    void Start()
    {
      detectRange = transform.localScale.x + 3.5f;
      target = GameObject.FindObjectOfType<PlayerMovement>().GetComponent<Transform>();
        playerReference = GameObject.Find("Player").GetComponent<PlayerBehavior>();
        camScriptRef = GameObject.Find("Main Camera").GetComponent<CameraScript>();
        //GameObject[] a = GameObject.FindGameObjectsWithTag("Destroyables");
        //foreach (GameObject destroyable in a)
        //{
        //    destroyables.Add(destroyable);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        if (leapOnce)
        {
            if (leapCount < 40)
            {
                leapCount++;
            }
            else
            {
                StartCoroutine(Leap(18, 0));
                camScriptRef.followPlayer = false;
                leapOnce = false;
            }
        }

        transform.Translate(movementSpeed * Time.deltaTime, 0, 0);
        DetectPlayer();
    }

    

    void DetectPlayer()
    {
        //Looks for the target's presence and (in the case Player) executes Death().
        dir = target.position - transform.position;
        Debug.DrawRay(transform.position, dir, Color.red);
        if (Physics.Raycast(transform.position, dir, detectRange, targetLayer))
        {
            playerReference.MonsterHit();   
        }
    }

    IEnumerator Leap(float leapDistance, float t)
    {
        float travel = transform.position.x + leapDistance;
        while(t < 1)
        {
            t += 0.03f;
            transform.position = new Vector3(Mathf.Lerp(transform.position.x, travel, t), transform.position.y, transform.position.z);
            yield return new WaitForFixedUpdate();
        }
        
    }
    //void CheckDestroyablesInRange()
    //{
    //    for (int i = 0; i < destroyables.Count; i++)
    //    {
    //        float distanceX = destroyables[i].transform.position.x - transform.position.x;
    //        if (distanceX < destroyableDistance + 15)
    //        {
    //            DestroyObject(destroyables[i]);
    //        }
    //    }
    //}

    //void DestroyObject(GameObject ob)
    //{
    //    Destroy(ob, 0.2f);
    //    destroyables.Remove(ob);
    //    //anim.Play("Destroy");
    //}
}
