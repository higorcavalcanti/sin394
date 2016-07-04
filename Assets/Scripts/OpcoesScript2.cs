using UnityEngine;
using System.Collections;

public class OpcoesScript2 : MonoBehaviour {

	
	public Texture Temperatura, Contorno;
	
	public static int score = 0;	
	public static int temperatura = 0;
	public static int recolhido = 0;
	
	public static int maxTemperatura = 3;
	public static int minTemperatura = 0;
	public GUIStyle customButton;
	
	// Use this for initialization
	void Start () {
		temperatura = minTemperatura;
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (temperatura >= maxTemperatura) {
			Application.LoadLevel(11);
		}
		
		if (score == 200) {
			//Application.LoadLevel(12); 	// Tela de Winner
			Application.LoadLevel(13);
		}

		if (recolhido == 300) {
			//Application.LoadLevel(12); 	// Tela de Winner
			Application.LoadLevel(13);
		}
	}
	void OnGUI(){
		GUI.Label (new Rect(Screen.width / 100, Screen.height / 13, Screen.width / 6, Screen.height / 12), "Pontuaçao: "+ score.ToString(),customButton);
		GUI.Label (new Rect(Screen.width / 100, Screen.height / 8, Screen.width / 7, Screen.height / 13), "Lixos recolhidos: "+ recolhido.ToString(),customButton);
		GUI.DrawTexture (new Rect (Screen.width / 40, Screen.height / 25, Screen.width / 8.3f/maxTemperatura*temperatura, Screen.height / 48), Temperatura);
		GUI.DrawTexture (new Rect (Screen.width / 100, Screen.height / 100, Screen.width / 6, Screen.height / 12), Contorno);
	}
}