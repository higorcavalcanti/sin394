using UnityEngine;
using System.Collections;

public class CarroScript: MonoBehaviour {
	public GameObject carroPrefab;// objeto que vai ser lançado na tela
	public GameObject carroPrefabAzul;// objeto que vai ser lançado na tela
	public GameObject caminhaoPrefab;// objeto que vai ser lançado na tela
	public GameObject caminhaoVerdePrefab;
	public GameObject carroPrefabVerde;
	public GameObject carroPrefabAzulClaro; // Carro
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
			int randonCar = Random.Range (1,8);
			if (randonCar == 1) {
				GameObject tempPrefab = Instantiate (carroPrefab) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y, transform.position.z);
			}else if(randonCar == 2){
				GameObject tempPrefab = Instantiate (carroPrefabAzul) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y, transform.position.z);
			}else if(randonCar == 3){
				GameObject tempPrefab = Instantiate(caminhaoVerdePrefab) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y , transform.position.z);
			}else if(randonCar == 4){
				GameObject tempPrefab = Instantiate(carroPrefabVerde) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y , transform.position.z);
			}else if(randonCar == 5){
				GameObject tempPrefab = Instantiate(carroPrefabAzulClaro) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y , transform.position.z);
			}else if (randonCar == 6 && randonCar == 7 ) {
				GameObject tempPrefab = Instantiate (carroPrefab) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y, transform.position.z);
			}else {
				GameObject tempPrefab = Instantiate(caminhaoPrefab) as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x, y , transform.position.z);
			}
		}
		
	}
}