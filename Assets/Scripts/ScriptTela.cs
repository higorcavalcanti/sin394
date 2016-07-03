using UnityEngine;
using System.Collections;

public class ScriptTela : MonoBehaviour {

	public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float amtToMove = speed * Time.deltaTime;
		transform.Translate (Vector3.left * amtToMove, Space.World);
		/*if(transform.position.x <= 3.7f)
		{
			transform.position = new Vector3(10.7f, 4.4f, transform.position.z);
		}*/

		if(transform.position.x <= -9.6f)
		{
			transform.position = new Vector3(9.7f, 4.4f, transform.position.z);
		}

	}
}