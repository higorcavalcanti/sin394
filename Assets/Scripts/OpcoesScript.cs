using UnityEngine;
using System.Collections;

public class OpcoesScript : MonoBehaviour {
	
	public static int score = 0;
	public static int vida = 3;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUI.Label (new Rect(10.0f,10.0f,105,20), "Pontuaçao: "+ score.ToString());
		GUI.Label (new Rect (10.0f, 30.0f, 70, 20), "Vidas: " + vida.ToString ());
	}

}
