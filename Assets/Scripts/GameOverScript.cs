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

		GUI.Label (new Rect(425,389,200,40), OpcoesScript.score.ToString(),style);

		if (GUI.Button (new Rect (355, 450, 289, 56), botaoJogar, GUIStyle.none)) {
			set = true;
			Application.LoadLevel(7);
			
		}
	}

}
