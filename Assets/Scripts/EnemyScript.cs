using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	public Transform target;
	public float moveSpeed;
	public int rotationSpeed;
	public int maxDistance;
	
	private Transform myTransform;

	void Awake(){
		myTransform = transform; 

	}
	
	// Use this for initialization
	void Start () {
		GameObject go = GameObject.FindGameObjectWithTag ("Player");
		
		target = go.transform;
		
		maxDistance = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (target.position.y > myTransform.position.y + maxDistance) {
			//animator.SetFloat ("row", Mathf.Abs(Input.GetAxis("Horizontal")));
			myTransform.position += Vector3.up * moveSpeed * Time.deltaTime;

		}
		if (target.position.y < myTransform.position.y - maxDistance) {
			myTransform.position += Vector3.down * moveSpeed * Time.deltaTime;

		}
		if (target.position.x > myTransform.position.x + maxDistance) {
			myTransform.position += Vector3.right * moveSpeed * Time.deltaTime;
			transform.eulerAngles = new Vector3 (0,180,0);
		}
		if (target.position.x < myTransform.position.x - maxDistance) {
			myTransform.position += Vector3.left * moveSpeed * Time.deltaTime;
			transform.eulerAngles = new Vector3 (0,0,0);
		}
	}
}
