using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeSetActiveFalse : MonoBehaviour
{
    void Awake() {this.gameObject.SetActive(false);}
}
