using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    Transform targetT;
    readonly string targetName = "Player";
    public float moveToPlayerSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        targetT = GameObject.Find(targetName).GetComponent<Transform>();
        //moveToPlayerSpeed = moveToPlayerSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        LockOnTarget();
    }

    private void LockOnTarget()
    {
       // float dist = Vector3.Distance(transform.position, targetT.position);
        //transform.position = new Vector3(Mathf.Lerp(transform.position.x, targetT.position.x, 0.1f * moveToPlayerSpeed), Mathf.Lerp(transform.position.y, targetT.position.y, 0.1f * moveToPlayerSpeed) + 0.2f, -17);
        transform.position = new Vector3(targetT.position.x, targetT.position.y + 4, -17);
    }
}
