﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaterKill : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D collider) {
		Destroy (collider.gameObject);
		RestartScene ();
	
	}

	public void RestartScene() {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
