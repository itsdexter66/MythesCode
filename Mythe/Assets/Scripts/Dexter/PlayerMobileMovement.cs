using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMobileMovement : MonoBehaviour
{

    //public Buttons jumpButton;
    bool CheckIfGrounded = true;
    PlayerMovement playMove;
    Vector3 jumpForce = new Vector3(0, 700, 0);

    void Start()
    {
        playMove = FindObjectOfType<PlayerMovement>();
    }

    void Update()
    {
        if (Input.GetButtonDown("jumpbutton"))
        {
            playMove.Jump();
        }
    }
}
