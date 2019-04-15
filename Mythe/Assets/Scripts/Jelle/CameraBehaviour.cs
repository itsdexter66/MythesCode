using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    Transform playerT;
    Transform targetT;
    public bool followPlayer = true;
    readonly string playerName = "Player";
    readonly string targetName = "ChasingMonster";
    public float moveToPlayerSpeed = 5;
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
            LockOnTarget(new Vector3(Mathf.Lerp(transform.position.x, playerT.position.x, 0.1f * moveToPlayerSpeed), Mathf.Lerp(transform.position.y, playerT.position.y, 0.1f * moveToPlayerSpeed) + 0.9f, -9));
        }
        if (!followPlayer)
        {
            LockOnTarget(new Vector3(targetT.position.x + 6, -4.5f, -9));
        }
    }

    public void LockOnTarget(Vector3 target)
    {
       transform.position = new Vector3(targetT.position.x + 6, -4.5f, -9);
    }
}
