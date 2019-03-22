using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public Action<int> playerAction;
    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}
    //// Update is called once per frame
    //void Update()
    //{
    //  if (transform.position.y < -8)
    //    {
    //        PlayerDeath(); 
    //    }
    //}

    public void MonsterHit()
    {
        PlayerDeath();
    }


    public static void PlayerDeath()
    {
        Application.LoadLevel("DeathScene");
    }
}
