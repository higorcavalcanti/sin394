using UnityEngine;
using System.Collections;

public class EnemyScript2 : MonoBehaviour {

	public float minSpeed;
	public float maxSpeed;
	public float currentSpeed;
	float x,y,z;



	// Use this for initialization
	void Start () {

		setPosition ();
	
	}
	
	// Update is called once per frame
	void Update () {
		float amtToMove = currentSpeed * Time.deltaTime;
		transform.Translate (Vector3.left * amtToMove, 0);

		if (transform.position.x < -0.51f) {
			setPosition();
			//Destroy(this.gameObject);
		}
	}

	public void setPosition(){
		currentSpeed = Random.Range (minSpeed, maxSpeed);
		x = 18.52f;
		y = Random.Range (-0.63f,0.20f);
		z = 0.0f;
		transform.position = new Vector3 (x, y, z);
	}


}
