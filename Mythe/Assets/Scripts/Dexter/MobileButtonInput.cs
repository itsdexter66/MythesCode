using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MobileButtonInput : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    PlayerMovement playermovement;

    bool ispressed = false;

    void Start()
    {
        playermovement = FindObjectOfType<PlayerMovement>();
    }

    void Update()
    {
        if (ispressed == true)
        {
            playermovement.Move();
            Debug.Log("button is being pressed");
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
        }
    }
}
