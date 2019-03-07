using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    bool isGrounded = false;
    Rigidbody playerRB;
    Vector3 jumpForce = new Vector3(0,450,0);
    [SerializeField]
    float movementSpeed;
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(movementSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-movementSpeed * Time.deltaTime, 0, 0);
        }

    }

    bool CheckIfGrounded()
    {
        int layerMask = 1 << 8;
        layerMask = ~layerMask;
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, 0.5f, layerMask))
        {
            isGrounded = true;
            return isGrounded;
        }
        else
        {
            isGrounded = false;
            return isGrounded;
        }
        
    }

    private void Jump()
    {
        if (CheckIfGrounded() == true)
        {
            playerRB.AddForce(jumpForce);
        }
    }
}
