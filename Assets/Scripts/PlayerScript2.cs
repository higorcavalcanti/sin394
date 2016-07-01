using UnityEngine;
using System.Collections;

public class PlayerScript2 : MonoBehaviour {

	public GameObject player;
	public float speed;
	private Animator animator;
	public GameObject ExplosionPrefab;
	Renderer rend;
	
	private OpcoesScript temperatura;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		rend = GetComponent<Renderer> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
		float vertical = Input.GetAxis ("Vertical") * speed * Time.deltaTime;
		player.transform.Translate (0, vertical, 0);

		float horizontal = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
		player.transform.Translate (horizontal, 0, 0);

		/*
		if(player.transform.position.y > maxHeigth){
			player.transform.position = new Vector2(0, maxHeigth);
		}

		if(player.transform.position.y < minHeigth){
			player.transform.position = new Vector2(0,minHeigth);
		}*/
	}

	void OnCollisionEnter2D(Collision2D colisor){
		if (colisor.gameObject.tag == "Enemy") {
			
			OpcoesScript.temperatura++;
			StartCoroutine(DestroyShip());
		}
		
		//Gambiarra! Arrumar
		if (colisor.gameObject.tag == "startFase1Tag") {
			Application.LoadLevel(8);
		}
		
	}
	
	IEnumerator DestroyShip(){
		Instantiate(ExplosionPrefab,transform.position,transform.rotation);
		rend.enabled = false;
		transform.position = new Vector3 (2.0f,0.2f,0);
		yield return new WaitForSeconds (1.5f);
		rend.enabled = true;
	}
}
