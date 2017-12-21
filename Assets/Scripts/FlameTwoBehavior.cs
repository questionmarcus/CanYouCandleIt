using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FlameTwoBehavior : MonoBehaviour {

	// Use this for initialization
	public Sprite sprite1;
	public Sprite sprite2;
	private SpriteRenderer spriteRenderer; 

	public void Start()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();
		//sprite1 = Resources.Load<Sprite>("texture1");
		//sprite2 = Resources.Load<Sprite>("texture2");
		if (spriteRenderer.sprite == null)
			spriteRenderer.sprite = sprite1;
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D collider) {
		ChangeSprite ();
		Destroy (collider.gameObject);
		GoToLevelTwo ();

	}

	void ChangeSprite() {
		if (spriteRenderer.sprite == sprite1) // if the spriteRenderer sprite = sprite1 then change to sprite2
		{
			spriteRenderer.sprite = sprite2;
		}
		else
		{
			spriteRenderer.sprite = sprite1; // otherwise change it back to sprite1
		}
	}

	public void GoToLevelTwo() {
		SceneManager.LoadScene ("TestSceneFour");
	}
}
