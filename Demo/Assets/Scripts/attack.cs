using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public Transform rangeattack;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            GetComponent<Transform>().position = new Vector2();
            Instantiate(rangeattack, new Vector2(), rangeattack.rotation);
        }
    }
}
