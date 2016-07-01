using UnityEngine;
using System.Collections;

public class MovimentarTelaScript : MonoBehaviour {

	private Material currentMaterial;
	public float speead;
	private float offset;

	// Use this for initialization
	void Start () {

		//currentMaterial = renderer.material;
		currentMaterial = GetComponent<Renderer> ().material;

	}
	
	// Update is called once per frame
	void Update () {

		offset += 0.001f;
		currentMaterial.SetTextureOffset ("_MainTex", new Vector2 (offset * speead, 0));
	
	}
}
