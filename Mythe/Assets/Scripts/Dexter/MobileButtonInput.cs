using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MobileButtonInput : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    PlayerMovement playermovement;
    [SerializeField] private bool rightButton;
                                  

    bool ispressed = false;

    void Start()
    {
        playermovement = FindObjectOfType<PlayerMovement>();
    }

    void Update()
    {    
        if (rightButton == true)
        {
            if (ispressed == true)
            {
                playermovement.MovePlayer(10, playermovement.movementSpeed);
            }
        }
        else if (ispressed == true)
        {
            playermovement.MovePlayer(-10,-playermovement.movementSpeed);
        }
    }
    

    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
        if (ispressed == false)
        {
            playermovement.playerAnim.Play("idle");
        }
    }
}
