using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    Transform targetT;
    readonly string targetName = "Player";
    // Start is called before the first frame update
    void Start()
    {
        targetT = GameObject.Find(targetName).GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        LockOnTarget();
    }

    private void LockOnTarget()
    {
        transform.position = new Vector3(targetT.position.x, targetT.position.y + 4, -17);
    }
}
