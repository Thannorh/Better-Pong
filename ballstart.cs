﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballstart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space");
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(450f, 350f));
        }
    }
}
