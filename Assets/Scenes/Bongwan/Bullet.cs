﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{   
    // Start is called before the first frame update
    void Start()
    {    
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,3.1f, 0); //0.1f 속도만큼 낙하

        if (transform.position.y < 5.0f){
        	Destroy(gameObject);
        }
    }
}
