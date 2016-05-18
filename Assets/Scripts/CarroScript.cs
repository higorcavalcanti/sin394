using UnityEngine;
using System.Collections;

public class CarroScript: MonoBehaviour {
	public GameObject carroPrefab;// objeto que vai ser lançado na tela
	public float rateSpawn;			  // intervalo de spawn
	public float currentTime;
	private int posicao;
	private float y;
	public float posA;
	public float posB;
	
	// Use this for initialization
	void Start () {
		currentTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
		currentTime += Time.deltaTime;
		if (currentTime >= rateSpawn) {
			currentTime = 0;
			posicao = Random.Range(1,100);
			if(posicao > 50){
				y = posA;
			}
			else{
				y = posB;
			}
			GameObject tempPrefab = Instantiate(carroPrefab) as GameObject;
			tempPrefab.transform.position = new Vector3 (transform.position.x, y , transform.position.z);
		}
		
	}
}