using UnityEngine;
using System.Collections;

public class LixoScript2 : MonoBehaviour {

	public GameObject Lixo1Prefab;// objeto que vai ser lançado na tela
	public GameObject Lixo2Prefab;// objeto que vai ser lançado na tela
	public GameObject Lixo3Prefab;// objeto que vai ser lançado na tela
	public GameObject Lixo4Prefab;// objeto que vai ser lançado na tela
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
			posicao = Random.Range (1, 100);
			if (posicao > 50) {
				y = posA;
			} else {
				y = posB;
			}
			int randomLixo = Random.Range (1,5);
			if (randomLixo == 1) {
				GameObject tempPrefab = Instantiate (Lixo1Prefab) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y, transform.position.z);
			}else if(randomLixo == 2){
				GameObject tempPrefab = Instantiate (Lixo2Prefab) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y, transform.position.z);
			}else if(randomLixo == 3){
				GameObject tempPrefab = Instantiate (Lixo3Prefab) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y, transform.position.z);
			}else if(randomLixo == 4){
				GameObject tempPrefab = Instantiate (Lixo4Prefab) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y, transform.position.z);
			}else{
				GameObject tempPrefab = Instantiate (Lixo1Prefab) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y, transform.position.z);
			}
		}
	}


}