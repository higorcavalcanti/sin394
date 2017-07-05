using UnityEngine;
using System.Collections;

public class WinnerScript : MonoBehaviour {

	public Texture botaoContinuar;
	private bool set;
	private OpcoesScript score;
	// Use this for initialization
	void Start () {
		Cursor.visible = true;
	
	}
	
	// Update is called once per frame
	void Update () {
		if(set = true){
			OpcoesScript.score = 0;
		}
	
	}
	void OnGUI(){

		if (GUI.Button (new Rect (Screen.width /2.8f, Screen.height / 1.3f, Screen.width / 4.5f, Screen.height / 6.5f), botaoContinuar, GUIStyle.none)) {
			set = true;
			Application.LoadLevel(3);
		}

		if (Input.GetKeyDown ("space")) {
			Application.LoadLevel (3);
		}
	}

}
