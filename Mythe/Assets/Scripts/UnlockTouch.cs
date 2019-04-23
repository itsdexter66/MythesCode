
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    
    public class UnlockTouch : MonoBehaviour
    {
        [SerializeField]
        LevelUnlock LU;
        public GameObject Player;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }


    public void OnTriggerEnter(Collider collision)
        {
            if (collision.gameObject == Player)
            {


                LU.Level2 = true;

            Debug.Log(LU.Level2);
            SceneManager.LoadScene("LevelSelect");

            }

            if (collision.gameObject == Player)
            {
                LU.Level3 = true;

            }
            else
            {

            }
        }
    }
