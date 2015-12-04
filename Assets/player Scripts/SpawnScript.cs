using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public Rigidbody Cheese;
	public Rigidbody Marble;

	public float MarbleSpeed = 2.0f;



	// Use this for initialization
	void Start () {
	
	}

	public void NewMarble(){
		if (GameControlScript.MarbleNumber < 25) {
			
			Rigidbody DupMarble = (Rigidbody)Instantiate (Marble, transform.position, transform.rotation); 
			Rigidbody DupMarble1 = (Rigidbody)Instantiate (Marble, transform.position, transform.rotation);
			Rigidbody DupMarble2 = (Rigidbody)Instantiate (Marble, transform.position, transform.rotation);
			
			DupMarble.velocity = transform.right * MarbleSpeed;
			DupMarble1.velocity = transform.forward * MarbleSpeed;
			DupMarble2.velocity = transform.forward * MarbleSpeed;

			//DupMarble.rigidbody.name = "Marble";
			//DupMarble1.rigidbody.name = "Marble";
			//DupMarble2.gameObject.name = "Marble";
		}

	}

	public void NewCheeseBall() {
		Rigidbody DupCheese = (Rigidbody)Instantiate (Cheese, transform.position, transform.rotation); 

		//DupCheese.name = "Cheese";
	}
	

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.Space))
		{
			//ADD new cheeseball
			NewCheeseBall();

			//Add new marble
			NewMarble();
			GameControlScript.MarbleNumber += 3;
		}

		/*if(Input.GetKeyDown (KeyCode.Space)){
			NewMarble();
			control.MarbleNumber = control.MarbleNumber + 3;
		}*/
	
	}
}
