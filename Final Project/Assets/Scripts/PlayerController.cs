﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject soccerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(soccerPrefab, transform.position, soccerPrefab.transform.rotation);
        }
    }
}
