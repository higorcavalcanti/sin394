using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float playerSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			
		float amtToMoveX = Input.GetAxisRaw ("Horizontal") * playerSpeed * Time.deltaTime;
		float amtToMoveY = Input.GetAxisRaw ("Vertical") * playerSpeed * Time.deltaTime;
		
		transform.Translate ( Vector3.right * amtToMoveX, Space.World );
		transform.Translate ( Vector3.up * amtToMoveY, Space.World );	
	}
}
