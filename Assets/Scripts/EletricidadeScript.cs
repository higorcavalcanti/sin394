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

	void OnTriggerEnter(Collider otherObject){
		if (otherObject.tag == "enemy") {
			OpcoesScript.score = OpcoesScript.score+10;
			
			if(OpcoesScript.score>=200){
				//Application.LoadLevel(2);
			}
			
			EnemyScript2 enemyScript2 = (EnemyScript2) otherObject.gameObject.GetComponent("EnemyScript2");
			Instantiate(ExplosionPrefab,enemyScript2.transform.position, enemyScript2.transform.rotation);
			enemyScript2.setPosition();
			Destroy(gameObject);
			
			
		}
	}
}
