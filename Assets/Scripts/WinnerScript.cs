using UnityEngine;
using System.Collections;

public class WinnerScript : MonoBehaviour {

	public Texture botaoContinuar;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	
	void OnGUI(){

		if (GUI.Button (new Rect (390, 470, 283, 50), botaoContinuar, GUIStyle.none)) {
			Application.LoadLevel(8);
			
		}
	}
}
