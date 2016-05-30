using UnityEngine;
using System.Collections;

public class MenuFasesScripts : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUI.Label (new Rect(10.0f,10.0f,30,30),"este");

		if (GUI.Button (new Rect (500, 350, 200, 45), "Nivel 1", GUIStyle.none)) {
			Application.LoadLevel(3);
		}
	}
}
