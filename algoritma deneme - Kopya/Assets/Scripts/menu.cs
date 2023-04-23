using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    public static menu Instance;
    public Button playbut, exitbut;
    private void Awake()
    {
        Instance = this;
    }


    void Update()
    {
        
    }
}
