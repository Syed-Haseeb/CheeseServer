using UnityEngine;
using System.Collections;

public class FlashLights : MonoBehaviour {

	public Vector3 pivot = new Vector3(-2.65f, 0.19f, 2.24f);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKey)
		{
			
			particleSystem.transform.RotateAround (pivot, Vector3.up, 45f * Time.deltaTime);  
	
		} 
		else
		{
			particleSystem.transform.RotateAround (pivot, Vector3.up, 90f * Time.deltaTime);
		}
	}
}
