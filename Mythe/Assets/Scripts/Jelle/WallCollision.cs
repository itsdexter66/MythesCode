using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{
    RaycastHit hitInfo;
    public Transform target;
    private Vector3 dir;
    public LayerMask targetLayer;
    private PlayerMovement playerMovement;
    readonly string playerName = "Player";
    float rayCastOffset = 0.5f;
    bool doOnce = true;
    void Start()
    {
        target = GameObject.FindObjectOfType<PlayerMovement>().GetComponent<Transform>();
        playerMovement = GameObject.Find(playerName).GetComponent<PlayerMovement>();
    }

    
    void Update()
    {
        if (InteractPlayer() && doOnce)
        {
            PutPlayerOnSurface();
            doOnce = false;
        }
    }

    bool InteractPlayer()
    {
        float rayDistance = transform.localScale.x / 2 + rayCastOffset;
        dir = target.position - transform.position;
        Debug.DrawRay(transform.position, dir, Color.blue);
        return Physics.Raycast(transform.position, dir, out hitInfo, rayDistance, targetLayer);
    }

    private void PutPlayerOnSurface()
    {
        Vector3 position;
        position.x = transform.position.x - (transform.localScale.x / 2);
        position.y = transform.position.y + (transform.localScale.y / 2);
        position.z = transform.position.z;
        target.transform.position = position;
    }
}
