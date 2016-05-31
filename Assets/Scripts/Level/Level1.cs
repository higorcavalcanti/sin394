using UnityEngine;
using System.Collections;

public class Level1 : MonoBehaviour {

	public GameObject enemyPrefab;
	public float timeToSpawn;

	private float cronometro;
	private float lastSpawn;

	// Use this for initialization
	void Start () {
		spawnEnemy ();
	}
	
	// Update is called once per frame
	void Update () {
		cronometro += Time.deltaTime;
		lastSpawn -= Time.deltaTime;

		if (lastSpawn <= 0) {
			spawnEnemy();
		}
	}


	void spawnEnemy() {
		lastSpawn = timeToSpawn;

		Vector3 pos = new Vector3 (0, 0, 0);
		Instantiate (enemyPrefab, pos, Quaternion.identity);
	}


}
