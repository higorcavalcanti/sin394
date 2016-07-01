using UnityEngine;
using System.Collections;

public class EletricidadeScript : MonoBehaviour {

	public float eletricidadeSpeed;
	public GameObject ExplosionPrefab;
	Renderer rend;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float amtToMove = eletricidadeSpeed * Time.deltaTime;
		transform.Translate (Vector3.right * amtToMove,0);

		if (transform.position.x > 18.0f) {
			Destroy(this.gameObject);
		}

	}

	void OnCollisionEnter2D(Collision2D colisor){
		if (colisor.gameObject.tag == "Enemy") {

			StartCoroutine(DestroyShip());
		}

		
	}
	
	IEnumerator DestroyShip(){
		Instantiate(ExplosionPrefab,transform.position,transform.rotation);
		rend.enabled = false;
		transform.position = new Vector3 (-19.68f,-13.03f,0);
		yield return new WaitForSeconds (1.5f);
		rend.enabled = true;
	}
}
