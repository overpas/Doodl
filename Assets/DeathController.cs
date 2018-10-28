using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathController : MonoBehaviour {

    public Camera myCamera;
    public Player player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (myCamera.transform.position.y > player.transform.position.y + 100)
        {
            Debug.Log("GAME OVER");
            Application.Quit();
        }
    }
}
