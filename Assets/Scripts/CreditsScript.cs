using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreditsScript : MonoBehaviour {

	public Button backButton;


	// Use this for initialization
	void Start () {
		backButton = backButton.GetComponent<Button> ();
	}

	// Update is called once per frame
	void Update () {

	}

	public void NoPress() {
		backButton.enabled = true;
	}

	//public void StartLevelSelection() {
	//	SceneManager.LoadScene ("LevelSelection");
	//}

	public void GoToMenu() {
		SceneManager.LoadScene ("MenuScene");
	}
		
}
