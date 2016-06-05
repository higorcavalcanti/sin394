using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	public Texture botaoJogar;
	private bool set;
	private OpcoesScript score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(set = true){
			OpcoesScript.score = 0;
		}
	}

	


	void OnGUI(){

		GUIStyle style = new GUIStyle();
		style.fontSize = 21;
	
		GUI.Label (new Rect(Screen.width / 2.5f, Screen.height / 1.534f, Screen.width /  3.5f, Screen.height /  5.5f), OpcoesScript.score.ToString(),style);
		
		if (GUI.Button (new Rect (Screen.width /3.01f, Screen.height / 1.3f, Screen.width / 3.5f, Screen.height / 5.5f), botaoJogar, GUIStyle.none)) {
			set = true;
			Application.LoadLevel(7);
			
		}
	}

}
