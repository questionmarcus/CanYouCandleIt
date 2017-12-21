using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	public Button playButton;
	public Button creditButton;

	// Use this for initialization
	void Start () {
		playButton = playButton.GetComponent<Button> ();
		creditButton = creditButton.GetComponent<Button> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void NoPress() {
		playButton.enabled = true;
		creditButton.enabled = true;
	}

	//public void StartLevelSelection() {
	//	SceneManager.LoadScene ("LevelSelection");
	//}

	public void StartPlay() {
		SceneManager.LoadScene ("TestSceneTwo");
	}

	public void GoToCredits() {
		SceneManager.LoadScene ("Credits");
	}
}
