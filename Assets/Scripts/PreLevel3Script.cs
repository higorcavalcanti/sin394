using UnityEngine;
using System.Collections;

public class PreLevel3Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Cursor.visible = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnGUI(){
		
		/*if (Input.anyKey) {
			Application.LoadLevel(7);
		}*/
		
		if (Input.GetKeyDown ("space")) {
			Application.LoadLevel (18);
			MapaJogoScript.level = 2;
		}
	}
}
