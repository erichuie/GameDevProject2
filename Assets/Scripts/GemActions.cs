﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemActions : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Player"){
            gameObject.SetActive(false);
        }
    }
}
