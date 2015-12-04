using UnityEngine;
using System.Collections;

//public GameObject PointKeeper;


public class PointKeeper : MonoBehaviour {

	public static bool MarbEaten = false;
	public int scoreValue;


	public void OnTriggerEnter(Collider other)
	{
		scoreValue = 1;

		//other.gameObject.name == "DupCheese") 
		if (other.gameObject.name == "Cheese(Clone)"){
			scoreValue = 5;
		


		}
		//other.gameObject.name == "Marble(Clone)" || 
		else if (other.gameObject.name == "Marble(Clone)") 
		{
			scoreValue = -1;
			GameControlScript.MarblesCollect += 1;

		}

		Destroy(other.gameObject);
		//Destroy(other.gameObject);

		//setting displayed text to score
		ScoreManager.score += scoreValue;


	}


	// Update is called once per frame
	void Update () {
		


	}
}
