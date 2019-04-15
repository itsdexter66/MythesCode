using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

    public bool automaticWalk = true;
    public bool impairedMovement = false, pressing;
    public float movementSpeed = 3.05f;
    public GameObject rightButton;
    public GameObject leftButton;
    public Animator playerAnim;
    private bool isGrounded;
    private bool isJumping = false;
    readonly float standartMoveSpeed = 3.05f;
    readonly float impairedMoveSpeed = 2;
    float counter, wearOffTIme = 1.5f;
    float jumpCounter;
    float jumpTimeTreshold = 1.13f;
    Rigidbody playerRB;
    Vector3 jumpForce = new Vector3(0,350,0);

    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
    }

    /// <summary>
    /// Update this instance.
    /// </summary>
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        //Automatic/Manual walking.
        if (automaticWalk == false)
        {
            rightButton.SetActive(true);
            leftButton.SetActive(true);

        }
        else
        {
            transform.Translate(movementSpeed * Time.deltaTime, 0, 0);
            if (!isJumping)
            {
                playerAnim.Play("run");
            }
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

        if (isJumping)
        {
            jumpCounter += Time.deltaTime;
            if (jumpCounter >= jumpTimeTreshold)
            {
                isJumping = false;
                jumpCounter = 0;
                playerAnim.Play("idle");
            }
        }
    }


    public void MovePlayer(float faceDirection, float amount)
    {
        if (!isJumping)
        {
            playerAnim.Play("run");
        }
        transform.localScale = new Vector3(faceDirection, 10, 10);
        transform.Translate(amount * Time.deltaTime, 0, 0);
    }
    /// <summary>
    /// Checks if grounded.
    /// </summary>
    /// <returns><c>true</c>, if if grounded was checked, <c>false</c> otherwise.</returns>
    bool CheckIfGrounded()
    {
        //Will return True if this object exists above another object.
        return Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out RaycastHit hit, 0.7f);
    }

    /// <summary>
    /// Jump this instance.
    /// </summary>
    public void Jump()
    {
        if (CheckIfGrounded() == true)
        {
            playerAnim.Play("jumpfall");
            playerRB.AddForce(jumpForce);
            isGrounded = true;
            isJumping = true;
        }
    }

    /// <summary>
    /// Ons the collision enter.
    /// </summary>
    /// <param name="other">Other.</param>
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Cave")
        {
            automaticWalk = false;
        }
    }
}
