using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceFunctions : MonoBehaviour
{
    string gameScene = "JelleScene1";
    public void Restart()
    {
        Application.LoadLevel(gameScene);
    }
}
