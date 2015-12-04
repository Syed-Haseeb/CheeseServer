using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	public static int score;

	Text countText;

	// Use this for initialization
	void Awake () {
		countText = GetComponent<Text> ();
		score = 0;
	}
	

	// Update is called once per frame
	void Update() {

		countText.text = "Score: " + score;//"Score: " + score;
	}
}
