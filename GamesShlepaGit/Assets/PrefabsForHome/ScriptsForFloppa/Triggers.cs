using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour
{
    public AudioSource musicTelephone;


    void Start()
    {
        musicTelephone = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Telephone")
            musicTelephone.Stop();
        
    }
}
