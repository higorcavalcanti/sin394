using UnityEngine;
using System.Collections;

public class PlayerScript2 : MonoBehaviour {

	public GameObject player;
	public float speed;
	private Animator animator;
	public GameObject ExplosionPrefab;
	public GameObject EletricidadePrefab;
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

		//Tiro
		if (Input.GetKeyDown ("space")) {
			Vector3 position = new Vector3(transform.position.x,transform.position.y + (transform.localScale.y/2));
			Instantiate(EletricidadePrefab,position, Quaternion.identity);
		}

		//Lado direito e esquedo
		if (transform.position.x <=1.5f)
			transform.position = new Vector3(1.5f,transform.position.y,transform.position.z);
		
		else if (transform.position.x >=15.0f)
			transform.position = new Vector3(15.0f,transform.position.y,transform.position.z);

		if (transform.position.y <=-1.0f)
			transform.position = new Vector3(transform.position.x, -1.0f,transform.position.z);
		
		else if (transform.position.y >=2.0f)
			transform.position = new Vector3(transform.position.x, 2.0f,transform.position.z);


	}

	void OnTriggerEnter(Collider otherObject){
		if (otherObject.tag == "enemy") {
			OpcoesScript.temperatura++;
			EnemyScript2 enemyScript2 = (EnemyScript2) otherObject.gameObject.GetComponent("EnemyScript2");
			enemyScript2.setPosition();
			StartCoroutine(DestroyShip());
		}
	}
	
	IEnumerator DestroyShip(){
		Instantiate(ExplosionPrefab,transform.position,transform.rotation);
		rend.enabled = false;
		transform.position = new Vector3 (0, 0, transform.position.z);
		yield return new WaitForSeconds(1.5f);
		rend.enabled = true;
	}
}
