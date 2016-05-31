using UnityEngine;
using System.Collections;

public class OpcoesScript : MonoBehaviour {
	
	public static int score = 0;
	
	public static int vida = 3;
	public Texture Temperatura,Contorno;
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
			//Application.LoadLevel(4);
		}
	}
	
	void OnGUI(){
		GUI.Label (new Rect(10.0f,10.0f,105,20), "Pontuaçao: "+ score.ToString());
		//GUI.Label (new Rect (10.0f, 30.0f, 70, 20), "Vidas: " + vida.ToString ());
		
		GUI.DrawTexture (new Rect (Screen.width / 40, Screen.height / 25, Screen.width / 8.3f/VidaCheia*vida, Screen.height / 48), Temperatura);
		GUI.DrawTexture (new Rect (Screen.width / 100, Screen.height / 100, Screen.width / 6, Screen.height / 12), Contorno);
	}
}