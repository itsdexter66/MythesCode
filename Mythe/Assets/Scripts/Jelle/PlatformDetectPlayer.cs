﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDetectPlayer : MonoBehaviour
{
    RaycastHit hitInfo;
    public Transform target;
    private Vector3 dir;
    public LayerMask targetLayer;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindObjectOfType<PlayerMovement>().GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (DetectPlayer())
        {
            SetBackPlayer();
        }
    }

    bool DetectPlayer()
    {
        float rayDistance = transform.localScale.x / 2 + 0.2f;
        //Clamp the Raycast to only be active on the left side.
        dir = target.position - transform.position;
        dir.y = Mathf.Clamp(dir.y, -0.3f, 0);
        if (dir.x > -1)
        {
            dir.x = -1;
        } 
        return Physics.Raycast(transform.position, dir, out hitInfo, rayDistance, targetLayer);
    }
    
    void SetBackPlayer(Transform obj = null, float force = 4)
    {
        Vector3 translation = new Vector3(-1,0,0) * force;
        switch (obj)
        {
            case null:
                hitInfo.transform.Translate(translation, Space.World);
            break;
            default:
                obj.Translate(translation, Space.World);
            break;
        }
    }
}
