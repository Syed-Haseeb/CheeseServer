using UnityEngine;
using System.Collections;

public class Floor : MonoBehaviour {

	public Rigidbody FloorTop;
	public Rigidbody FloorBottom;
	public float BottturnSpeed= 45f;
	public float TopturnSpeed= -45f;

	public bool JPressed = false;


	// Use this for initialization
	void Start () {
		FloorBottom.transform.Rotate (0, 0, 0);
		FloorTop.transform.Rotate (0, 45, 0);



	}
	
	// Update is called once per frame
	void Update () 
	{ 
		//if any key is pressed, background stops
		//spinning, signalling a false key has been pressed

		if (Input.anyKey == true)
		{

			if(Input.GetKey (KeyCode.DownArrow)) 
			{
				
				FloorBottom.transform.Rotate(Vector3.up, BottturnSpeed/6  * Time.deltaTime);
				
				FloorTop.transform.Rotate(Vector3.up, TopturnSpeed/6 * Time.deltaTime);
				
			}
			
			else if(Input.GetKey (KeyCode.UpArrow))
			{
				
				FloorBottom.transform.Rotate(Vector3.up, TopturnSpeed/4 * Time.deltaTime);
				
				FloorTop.transform.Rotate(Vector3.up, BottturnSpeed/4 * Time.deltaTime);					
			}

			else if(Input.GetKey (KeyCode.RightArrow))
			{
				
				FloorBottom.transform.Rotate(Vector3.up, TopturnSpeed/4 * Time.deltaTime);
				
				FloorTop.transform.Rotate(Vector3.up, BottturnSpeed/4 * Time.deltaTime);					
			}

			else if(Input.GetKey (KeyCode.LeftArrow))
			{
				
				FloorBottom.transform.Rotate(Vector3.up, TopturnSpeed/6 * Time.deltaTime);
				
				FloorTop.transform.Rotate(Vector3.up, BottturnSpeed/6 * Time.deltaTime);					
			}
		}
		
		else
		{
					FloorBottom.transform.Rotate (Vector3.up, BottturnSpeed* Time.deltaTime);
			
					FloorTop.transform.Rotate (Vector3.up, TopturnSpeed * Time.deltaTime);

		}



	}
}
