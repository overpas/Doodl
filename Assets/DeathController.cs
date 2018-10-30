﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathController : MonoBehaviour {

    public Camera myCamera;
    public PlayerController player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (myCamera.transform.position.y > player.transform.position.y + 6)
        {
            Debug.Log("GAME OVER");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
