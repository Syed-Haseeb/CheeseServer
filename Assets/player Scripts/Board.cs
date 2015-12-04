using UnityEngine;
using System.Collections;

public class Board : MonoBehaviour {


	//public float moveSpeed = 10f;
	//public float turnSpeed = 25f;



	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		
		float horRot = (Input.GetAxis("Horizontal")) * Time.deltaTime * -10;
		float vertRot = (Input.GetAxis("Vertical")) * Time.deltaTime * -10;

		float totalHorRot;
		float totalVertRot;
		
		if (transform.eulerAngles.x + horRot < 350) {
			totalHorRot = transform.eulerAngles.x + horRot;
		} else {
			totalHorRot = transform.eulerAngles.x + horRot - 360;// - 360;
		}
		
		if (transform.eulerAngles.z + vertRot < 350) {
			totalVertRot = transform.eulerAngles.z + vertRot;
		} else {
			totalVertRot = transform.eulerAngles.z + vertRot - 360;
		}
		
		transform.rotation = Quaternion.Euler(Mathf.Clamp(totalHorRot, -5.5f, 5.5f), 0, Mathf.Clamp(totalVertRot, -5.5f, 5.5f));

		/*if (Input.GetKeyDown (KeyCode.DownArrow))
		{
			//transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
			transform.RotateAround(Vector3.up, 5f);
		}

		else if (Input.GetKeyDown (KeyCode.RightArrow))
		{
			//transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
			transform.RotateAround(Vector3.left, 5f);
		}

		else if (Input.GetKeyDown (KeyCode.LeftArrow))
		{
			//transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
			transform.RotateAround(Vector3.right, 5f);
		}

		else if (Input.GetKeyDown (KeyCode.UpArrow))
		{
			//transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
			transform.RotateAround(Vector3.down, 5f);
		}*/

	}
}
