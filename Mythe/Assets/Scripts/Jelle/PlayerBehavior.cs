using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    

    public void MonsterHit()
    {
        PlayerDeath();
    }


    public static void PlayerDeath()
    {
        Application.LoadLevel("DeathScene");
    }
}
