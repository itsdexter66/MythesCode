using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    [SerializeField]
    private string Tag;
    private AudioSource Sound;

  
    void Start()
    {
        Sound = GetComponent<AudioSource>();
    }
    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision){

        if (collision.gameObject.tag == Tag)
        {
            Sound.Play();
        }
    }
}
