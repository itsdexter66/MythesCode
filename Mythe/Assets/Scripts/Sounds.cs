using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    [SerializeField]
    private string Tag;
    private AudioSource Sound;
    [SerializeField]
    private AudioSource Music;


    void Start()
    {
        Sound = GetComponent<AudioSource>();
        Music.Play();
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
