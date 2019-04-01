using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MobileInputHandler : MonoBehaviour
{
    [SerializeField]
    string currentButton;
    Image spriteButton;
    // Start is called before the first frame update
    void Start()
    {
        spriteButton = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnMouseDown()
    {
        Debug.Log("Mew");
        if (currentButton == "Right")
        {
            Debug.Log("RightB");
        }

        if (currentButton == "Left")
        {
            Debug.Log("LeftB");
        }
    }

}
