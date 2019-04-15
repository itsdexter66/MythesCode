using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCave : MonoBehaviour
{
    Transform targetPlayer;
    readonly string targetName = "Player";
    // Start is called before the first frame update
    void Awake()
    {
        targetPlayer = GameObject.Find(targetName).GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        LockOnPlayer();
    }
    public void LockOnPlayer() { 
        
          transform.position = new Vector3(targetPlayer.position.x, targetPlayer.position.y + 3, -7);
    }
}
