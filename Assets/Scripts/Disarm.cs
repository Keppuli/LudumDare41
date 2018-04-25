﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disarm : MonoBehaviour {

    public GameObject audioManager;
    public AudioClip disarmSound;

    void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("AudioManager");
    }
    void OnTriggerEnter2D(Collider2D col)
    {
       
        if (col.tag == "Player")
        {
            Debug.Log("Player Disarmed");
            GameManager.bombs = 0;
            GameManager.bombsFreeze = 0;
            audioManager.GetComponent<AudioManager>().Play(disarmSound);
        }
    }
}