using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public bool gameOver = false;
    public int score = 0;
    public static GameController instance;
    public float spawnTime = 4f;
    public float elapsedTime = 0f;
    public Text tiempo;

    // Use this for initialization
    void Start () {
        instance = this;
        tiempo.text = "Tiempo: " + elapsedTime.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
        if (elapsedTime < spawnTime)
        {
            elapsedTime += Time.deltaTime;
        }
    }

    //public void OnGui()
    //{
    //    GUI.Box(new Rect(0, 1, Screen.width, Screen.height - 50), tiempo);
   // }
}
