using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    Transform playerT;
    Transform targetT;
    public bool followPlayer = true;
    readonly string playerName = "Player";
    readonly string targetName = "ChasingMonster";
<<<<<<< HEAD
    public float moveToPlayerSpeed = 5;
=======
    float moveToPlayerSpeed = 5;
>>>>>>> 0b3035449e41390c785fc4345680cfd892dcfe2f
    // Start is called before the first frame update
    void Start()
    {
        targetT = GameObject.Find(targetName).GetComponent<Transform>();
        playerT = GameObject.Find(playerName).GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (followPlayer)
        {
            LockOnPlayer();
        }
        if (!followPlayer)
        {
            LockOnTarget();
        }
    }

    private void LockOnPlayer()
    {
        //transform.position = new Vector3(Mathf.Lerp(transform.position.x, playerT.position.x, 0.1f * moveToPlayerSpeed), Mathf.Lerp(transform.position.y, playerT.position.y, 0.1f * moveToPlayerSpeed) + 0.2f, -17);
        transform.position = new Vector3(playerT.position.x, playerT.position.y + 3, -17);
    }

    private void LockOnTarget()
    {
<<<<<<< HEAD
        transform.position = new Vector3(targetT.position.x + 15, transform.position.y, -17);
=======
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, targetT.position.x + 15, 0.1f * moveToPlayerSpeed), Mathf.Lerp(transform.position.y, targetT.position.y, 0.1f * moveToPlayerSpeed) + 0.2f, -17);
>>>>>>> 0b3035449e41390c785fc4345680cfd892dcfe2f
    }
}
