using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float playerSpeed;
	public Transform player;
	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		Movimentar ();
	}

	void Movimentar(){
		animator.SetFloat ("run", Mathf.Abs(Input.GetAxis("Horizontal")));
		animator.SetFloat ("runVerticalCima",Input.GetAxis("Vertical"));
		animator.SetFloat ("runVerticalBaixo", Mathf.Abs(Input.GetAxis("Vertical")));

		if (Input.GetAxisRaw ("Horizontal") > 0) {
			transform.Translate ( Vector2.right * playerSpeed * Time.deltaTime);
			transform.eulerAngles = new Vector2 (0,0);
		}

		if (Input.GetAxisRaw ("Horizontal") < 0) {
			transform.Translate ( Vector2.right * playerSpeed * Time.deltaTime);
			transform.eulerAngles = new Vector2 (0,180);
		}

		if (Input.GetAxisRaw ("Vertical") > 0) {
			transform.Translate (Vector2.up * playerSpeed * Time.deltaTime);



		} else if (Input.GetAxisRaw ("Vertical") < 0) {
			transform.Translate (Vector2.down * playerSpeed * Time.deltaTime);


		}



		
	}
}
