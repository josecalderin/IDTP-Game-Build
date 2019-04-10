using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinpickup : MonoBehaviour
{

    //public GameObject explosion;





    void OnCollisionEnter2D(Collision2D coll)
    {
        // If a missile hits this object
        if (coll.gameObject.tag == "Player")
        {
            HudText.scoreValue += 1;
            Debug.Log("HIT!");
            Destroy(gameObject);

        }

    }
}

