﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shadowmove : MonoBehaviour {

    // Use this for initialization
    void Start() {
        GetComponent<Rigidbody>().velocity = new Vector2(10, 0);
        //gameObject.layer = 0;
        
    }

    // Update is called once per frame
    void OnParticleCollision(GameObject other)
    {

        if (other.tag == "enemy")
        {
            Destroy(gameObject);
            Destroy(GameObject.FindWithTag("enemy"));
            //Debug.Log("hit!!!");
            
        }
        else
        {
            Destroy(gameObject, 2.5f);
        }
    }
}