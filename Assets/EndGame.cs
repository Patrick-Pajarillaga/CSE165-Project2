﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        
    }

    void FixedUpdate() {
        
    }

    void OnTriggerEnter(Collider other) {
        Debug.Log("Enter");
        text.SetActive(true);
    }
}