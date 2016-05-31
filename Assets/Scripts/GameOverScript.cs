using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {
	public Texture botaoJogar;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		if (GUI.Button (new Rect (355, 450, 289, 56), botaoJogar, GUIStyle.none)) {
			Application.LoadLevel(3);
			
		}
	}

}
