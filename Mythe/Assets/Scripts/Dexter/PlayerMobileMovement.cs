using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMobileMovement : MonoBehaviour
{

    //public Buttons jumpButton;
    bool CheckIfGrounded = true;
    Rigidbody playerRB;
    Vector3 jumpForce = new Vector3(0, 700, 0);

    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //if (Input.GetButtonDown("jumpbutton"))
        //{
        //    Jump();
        //}
    }

    public void Jump()
    {
        if (CheckIfGrounded == true)
        {
            playerRB.AddForce(jumpForce);
        }
    }
}
