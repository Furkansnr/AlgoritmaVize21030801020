using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class singleton : MonoBehaviour
{
    public static singleton instance;
    public AudioSource sesler;
    public AudioClip oyunsesi;
    public delegate void OyunBittiDel();
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        
    }

    private void Start()
    {
       
        sesler.PlayOneShot(oyunsesi); 
    }
}
