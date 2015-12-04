using UnityEngine;

using System.Collections;

public class GameControlScript : MonoBehaviour { 
	public GUISkin skin;

	public static int MarblesCollect = 0;
	//int PointGain = 5f;
	//int PointLoss = 1f;

	public bool isGameOver = false;
	public static int MarbleNumber = 0;


	//if UNITY_WEBPLAYER
	public static string webplayerQuitURL = "http://google.com";


	// Use this for initialization
	void Start () {
		//TotScore = 0;
		Time.timeScale = 1;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.E)) 
		{
			Quit();
		}

		if (isGameOver)
		{
			//Lauch UI displaying "Game Over"
			// Prompt user to enter a key to return to start menu
			Quit ();
			

		}

		if (MarblesCollect >= 5) 
		{
			isGameOver = true;
		}





	}

	public static void Quit()
	{
		//if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		//elif UNITY_WEBPLAYER
		//Application.OpenURL(webplayerQuitURL);
		//else
		Application.Quit();
		//endif
	}
	/*void OnGUI()
	{
		GUI.skin = skin;

		//check if game is not over, if so, display the score and the time left
		if(!isGameOver)    
		{

			GUI.Label(new Rect(Screen.width-(Screen.width/6), 0, Screen.width/6, Screen.height/6), "SCORE: "+((int)ScoreManager.score).ToString());
		}
		//if game over, display game over menu with score
		else
		{
			Time.timeScale = 0; //set the timescale to zero so as to stop the game world
			//display the final score
			//GUI.Box(new Rect(Screen.width/4, Screen.height/4, Screen.width/2, Screen.height/2), "GAME OVER\nYOUR SCORE: "+(int)score);
			
			//restart the game on click
			if (GUI.Button(new Rect(Screen.width/4+10, Screen.height/4+Screen.height/10+10, Screen.width/2-20, Screen.height/10), "RESTART")){
				Application.LoadLevel(Application.loadedLevel);
			}
			
			//load the main menu, which as of now has not been created
			if (GUI.Button(new Rect(Screen.width/4+10, Screen.height/4+2*Screen.height/10+10, Screen.width/2-20, Screen.height/10), "MAIN MENU")){
				Application.LoadLevel(1);
			}
			
			//exit the game
			if (GUI.Button(new Rect(Screen.width/4+10, Screen.height/4+3*Screen.height/10+10, Screen.width/2-20, Screen.height/10), "EXIT GAME")){
				Application.Quit();
			}
		}
	}*/
}
