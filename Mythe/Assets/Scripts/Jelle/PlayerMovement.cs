using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool automaticWalk = true;
    Rigidbody playerRB;
    Vector3 jumpForce = new Vector3(0,350,0);
    public float movementSpeed = 6;
    float standartMoveSpeed = 6;
    float impairedMoveSpeed = 2;
    public bool impairedMovement = false;
    float counter,wearOffTIme = 1.5f;
    private bool isGrounded;

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
        //Automatic/Manual walking.
        if (automaticWalk == false)
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(movementSpeed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(-movementSpeed * Time.deltaTime, 0, 0);
            }
        }
        else
        {
            transform.Translate(movementSpeed * Time.deltaTime, 0, 0);
        }

        //Impaired Movement
        if (impairedMovement)
        {
            movementSpeed = impairedMoveSpeed;
            counter += Time.deltaTime;
            if (counter > wearOffTIme)
            {
                movementSpeed = standartMoveSpeed;
                counter = 0;
                impairedMovement = false;
            }
        }
    }

    bool CheckIfGrounded()
    {
        //Will return True if this object exists above another object.
        return Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out RaycastHit hit, 0.7f);                
    }

    private void Jump()
    {
        if (CheckIfGrounded() == true)
        {
            playerRB.AddForce(jumpForce);
            isGrounded = true;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Cave")
        {
            automaticWalk = false;
        }
    }
}
