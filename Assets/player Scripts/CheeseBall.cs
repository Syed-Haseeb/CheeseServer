using UnityEngine;
using System.Collections;

public class CheeseBall : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "DupCheese" || other.gameObject.name == "Cheese") 
		{
			//		
		}
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
