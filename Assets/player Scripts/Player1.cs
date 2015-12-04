using UnityEngine;
using System.Collections;

public class Player1 : MonoBehaviour {
	
	CharacterController controller;
	//bool isGrounded = false;
	//private Vector3 moveDirection = Vector3.zero;
	float WaitTime = 3.0f;
	
	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () { 
		animation.Play ("WaitAnim");

		WaitTime -= Time.deltaTime;
		
		if (Input.GetKeyDown (KeyCode.DownArrow) == true) {
						
						animation.Stop("WaitAnim");
						animation.Play ("Slam_down");
			
						WaitTime = 3.0f;

			//if(Input.GetKey(KeyCode.DownArrow)){ animation.Play("M_look");}
			} 
			
		else if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.LeftArrow)){

			animation.Stop("WaitAnim");
			animation.Play("M_look");
		}
	}
}
