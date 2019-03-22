using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceFunctions : MonoBehaviour
{
    //string gameScene = "JelleScene1";
    private string gameScene = "SemScene";
    public void Restart()
    {
        Application.LoadLevel(gameScene);
    }
}
