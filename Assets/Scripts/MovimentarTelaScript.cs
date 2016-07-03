using UnityEngine;
using System.Collections;

public class MovimentarTelaScript : MonoBehaviour {

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
		
		if(transform.position.x <= 7.7f)
		{
			transform.position = new Vector3(26.7f, 4.49f, 1.33169f);
		}
	
	}
}
