using UnityEngine;
using System.Collections;

public class WinnerScript : MonoBehaviour {

	public Texture botaoContinuar;
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

		if (GUI.Button (new Rect (390, 470, 283, 50), botaoContinuar, GUIStyle.none)) {
			set = true;
			Application.LoadLevel(3);
		}
	}
}
