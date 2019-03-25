using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceFunctions : MonoBehaviour
{
    //string gameScene = "JelleScene1";
    private string gameScene = "TutorialLevel";
    public void Restart()
    {
        Application.LoadLevel(gameScene);
    }
}
