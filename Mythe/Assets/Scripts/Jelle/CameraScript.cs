using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    Transform playerT;
    Transform targetT;
<<<<<<< HEAD
    public bool followPlayer = true;
    readonly string playerName = "Player";
    readonly string targetName = "ChasingMonster";
    float moveToPlayerSpeed = 5;
=======
    readonly string targetName = "Player";
    public float moveToPlayerSpeed = 5;
>>>>>>> f30d7329827a33c8e3dd1c3f3d9cde10935713b7
    // Start is called before the first frame update
    void Start()
    {
        targetT = GameObject.Find(targetName).GetComponent<Transform>();
        playerT = GameObject.Find(playerName).GetComponent<Transform>();
        moveToPlayerSpeed = moveToPlayerSpeed / 10;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (followPlayer)
        {
            LockOnPlayer();
        }
        else
        {
            LockOnTarget();
        }
    }

    private void LockOnPlayer()
    {
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, playerT.position.x, 0.1f * moveToPlayerSpeed), Mathf.Lerp(transform.position.y, playerT.position.y, 0.1f * moveToPlayerSpeed) + 0.2f, -17);
    }

    private void LockOnTarget()
    {
<<<<<<< HEAD
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, targetT.position.x + 15, 0.1f * moveToPlayerSpeed), Mathf.Lerp(transform.position.y, targetT.position.y, 0.1f * moveToPlayerSpeed) + 0.2f, -17);
=======
        //float dist = Vector3.Distance(transform.position, targetT.position);
        //float t = 0.5f;
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, targetT.position.x, 0.1f * moveToPlayerSpeed), Mathf.Lerp(transform.position.y, targetT.position.y, 0.1f * moveToPlayerSpeed) + 0.2f, -17);
>>>>>>> f30d7329827a33c8e3dd1c3f3d9cde10935713b7
    }
}
