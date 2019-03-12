using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBehavior : MonoBehaviour
{
    [SerializeField]
    float movementSpeed;
    public LayerMask targetLayer;
    float detectRange;
    private Vector3 dir;
    Transform target;
    PlayerBehavior scriptReference;
    int leapCount;
    bool leapOnce = true;
    // Start is called before the first frame update
    void Start()
    {
      detectRange = transform.localScale.x + 2.5f;
      target = GameObject.FindObjectOfType<PlayerMovement>().GetComponent<Transform>();
      scriptReference = GameObject.FindObjectOfType<PlayerBehavior>();
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
                Leap();
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
        Debug.Log(target.position);
        Debug.DrawRay(transform.position, dir, Color.red);
        if (Physics.Raycast(transform.position, dir, detectRange, targetLayer))
        {
            scriptReference.Death();
        }
    }

    void Leap()
    {
        transform.Translate(10, 0, 0);
    }

}
