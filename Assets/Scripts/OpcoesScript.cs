using UnityEngine;
using System.Collections;

public class OpcoesScript : MonoBehaviour {
	
	public static int score = 0;

	public static int vida = 3;
	public Texture Sangue,Contorno;
	public int VidaCheia = 100;

	// Use this for initialization
	void Start () {
		vida = VidaCheia;
	}
	
	// Update is called once per frame
	void Update () {
		if (vida >= VidaCheia) {
			vida = VidaCheia;
		} else if (vida <= 0) {
			Application.LoadLevel(4);
		}
	}

	void OnGUI(){
		//GUI.Label (new Rect(10.0f,10.0f,105,20), "Pontuaçao: "+ score.ToString());
		//GUI.Label (new Rect (10.0f, 30.0f, 70, 20), "Vidas: " + vida.ToString ());

		GUI.DrawTexture (new Rect (Screen.width / 25, Screen.height / 15, Screen.width / 5.5f/VidaCheia*vida, Screen.height / 25), Sangue);
		GUI.DrawTexture (new Rect (Screen.width / 40, Screen.height / 40, Screen.width / 5, Screen.height / 8), Contorno);
	}
}