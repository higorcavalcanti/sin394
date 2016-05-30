using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

	public Texture botaoPlay;
	public Texture botaoOpcoes;
	public Texture botaoInstrucoes;
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

		if (GUI.Button (new Rect (500, 400, 198, 45), botaoInstrucoes, GUIStyle.none)) {
			Application.LoadLevel(2);
			
		}

		if (GUI.Button (new Rect (500, 450, 198, 45), botaoOpcoes, GUIStyle.none)) {
			Application.LoadLevel(1);
			
		}
	}
}
