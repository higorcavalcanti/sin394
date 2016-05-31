using UnityEngine;
using System.Collections;

public class Level1 : MonoBehaviour {

	public float cronometro;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		cronometro += Time.deltaTime;
		if (cronometro >= 3) {

		}

	}


}
