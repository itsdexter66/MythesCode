using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnPressed : MonoBehaviour
{

    public Action Escpressed;


    void Start()
    {
        
    }

    void Update()
    {
        Hitesc();
    }

    void Hitesc()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("cool");
            //Escpressed();
        }
    }
}
