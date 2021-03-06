﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableLevel : MonoBehaviour {

    public GameObject level;    // Stores reference to a parent obj that holds all tutorial level assets as childobject
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Player")
        {
            Debug.Log("Level Enabled");
            // Tutorial level is disabled by default for optimization, this activates it
            level.SetActive(true);
        }
    }
}
