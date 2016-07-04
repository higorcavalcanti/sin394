using UnityEngine;
using System.Collections;

public class MoveScript2 : MonoBehaviour {

	public float speed;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		float amtToMove = speed * Time.deltaTime;
		transform.Translate (Vector3.left * amtToMove, 0);

		if (transform.position.x <= -0.3f) {
			Destroy(transform.gameObject);
		}
		
		
	}
	


}
