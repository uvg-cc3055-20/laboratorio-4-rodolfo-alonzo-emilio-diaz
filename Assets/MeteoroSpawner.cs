﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoroSpawner : MonoBehaviour {
    public GameObject meteorBrown_big2;
    public float spawnTime = 4f;
    public float elapsedTime = 0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        {
            if (GameController.instance.gameOver == false)
            {
                if (elapsedTime < spawnTime)
                {
                    elapsedTime += Time.deltaTime;
                }
                else
                {
                    float random = Random.Range(-2f, 2f);
                    Instantiate(meteorBrown_big2, new Vector3(random, 8, 0), Quaternion.identity);
                    elapsedTime = 0;
                }
            }
        }
    }
}
