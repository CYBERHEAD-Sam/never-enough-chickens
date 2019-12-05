﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float forwardInput;
    private float rotateSpeed = 175.0f;
    private float speed = 17.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //move player forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime * forwardInput);
        //turn player
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime * horizontalInput);
    }
}
