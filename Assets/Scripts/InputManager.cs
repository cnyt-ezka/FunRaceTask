﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
            GetComponent<Animator>().SetBool("IsRunning", true);
        else
            GetComponent<Animator>().SetBool("IsRunning", false);
    }
}