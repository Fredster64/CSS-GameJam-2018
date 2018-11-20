﻿using UnityEngine;
using System;
using System.Collections.Generic;
public class PickupController : MonoBehaviour {

    public Sprite UISprite;
    public string objectName;
    public bool picked = false;

    private void Start()
    {
        System.Random ran = new System.Random();
        float pX = (float)(2 * ((ran.Next(0, 100) / (double)100)  * Math.Floor((double)(MazeGenerator.mazeSize - 1) / 2)) + 1);
        transform.position = new Vector3((float)(pX ), (float)(pX ), 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !picked)
        {   
            InventoryController.Instance.add( UISprite, objectName );
            Destroy(gameObject);
        }
    }
}
