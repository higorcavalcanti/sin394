using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

	public Texture botaoPlay;
	public Texture botaoOpcoes;
	public Texture botaoInstrucoes;
	public Texture botaoCreditos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		if (GUI.Button (new Rect (500, 350, 200, 45), botaoPlay, GUIStyle.none)) {
			Application.LoadLevel(3);
		}

		if (GUI.Button (new Rect (740, 350, 198, 45), botaoOpcoes, GUIStyle.none)) {
			Application.LoadLevel(1);
			
		}

		if (GUI.Button (new Rect (500, 410, 198, 45),botaoCreditos , GUIStyle.none)) {
			Application.LoadLevel(4);
			
		}

		if (GUI.Button (new Rect (740, 410, 198, 45), botaoInstrucoes, GUIStyle.none)) {
			Application.LoadLevel(2);
			
		}
	}
}
