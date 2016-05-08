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
		if (GUI.Button (new Rect (300, 200, 150, 35), botaoPlay, GUIStyle.none)) {
			Application.LoadLevel(1);
		}

		if (GUI.Button (new Rect (300, 250, 150, 35), botaoOpcoes, GUIStyle.none)) {
			
		}
	}
}
