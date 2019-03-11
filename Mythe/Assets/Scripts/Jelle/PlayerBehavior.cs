using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (transform.position.y < -8)
        {
            Death();
        }   
    }

    public void Death()
    {
        //Highscore code here, if we decide to implement it.
        Application.LoadLevel("DeathScene");
    }
}
