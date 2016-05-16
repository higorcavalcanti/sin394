using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

	public Texture botaoPlay;
	public Texture botaoOpcoes;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		if (GUI.Button (new Rect (500, 350, 200, 45), botaoPlay, GUIStyle.none)) {
			Application.LoadLevel(1);
		}

		if (GUI.Button (new Rect (500, 400, 200, 45), botaoOpcoes, GUIStyle.none)) {
			
		}
	}
}
