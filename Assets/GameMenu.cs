using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : MonoBehaviour {

    public static GameMenu instance;
    public float spawnTime = 4f;
    public float elapsedTime = 0f;

    // Use this for initialization
    void Start () {
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {

        if (elapsedTime < spawnTime)
        {
            elapsedTime += Time.deltaTime;
        }

    }
}
