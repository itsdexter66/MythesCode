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
                playermovement.MoveRight();
            }
        }
        else if (ispressed == true)
        {
            playermovement.MoveLeft();
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
            Debug.Log("button is not being pressed");
            playermovement.playerAnim.Play("idle");
        }
    }
}
