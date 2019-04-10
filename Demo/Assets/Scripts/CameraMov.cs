using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour

{

    public GameObject player;       //Public variable to store a reference to the player game object
    private int movingSpeed = (int)4f;

        
    void Update()
    {
        transform.position += Vector3.right * Time.deltaTime * movingSpeed;
        {

        }
    }
}