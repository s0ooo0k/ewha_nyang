﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void LButtonDown(){
        transform.Translate(-30, 0, 0);
    }

    public void RButtonDown(){
        transform.Translate(30, 0, 0);
    }
    
}