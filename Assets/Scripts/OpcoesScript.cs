using UnityEngine;
using System.Collections;

public class OpcoesScript : MonoBehaviour {
	
	public Texture Temperatura, Contorno;
	
	public static int score = 0;	
	public static int temperatura = 0;
	
	public static int maxTemperatura = 3;
	public static int minTemperatura = 0;
	
	// Use this for initialization
	void Start () {
		temperatura = minTemperatura;
	}
	
	// Update is called once per frame
	void Update () {
		if (temperatura >= maxTemperatura) {
			Application.LoadLevel(5);
		}
		
		if (score == 200) {
			//Application.LoadLevel(6); 	// Tela de Winner
			Application.LoadLevel(9);
		}
	}
	void OnGUI(){
		GUI.Label (new Rect(Screen.width / 100, Screen.height / 13, Screen.width / 6, Screen.height / 12), "Pontuaçao: "+ score.ToString());
		GUI.DrawTexture (new Rect (Screen.width / 40, Screen.height / 25, Screen.width / 8.3f/maxTemperatura*temperatura, Screen.height / 48), Temperatura);
		GUI.DrawTexture (new Rect (Screen.width / 100, Screen.height / 100, Screen.width / 6, Screen.height / 12), Contorno);
	}
}