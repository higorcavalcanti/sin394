using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class GameManager1 : MonoBehaviour {


	public Card1 carda;

	public Sprite[] cardFace;
	public Sprite cardBack;
	public GameObject[] cards;
	public Text matchText;
	public Text tentatitvasText;

	public bool _init = false;
	public int _matches = 3;

    private bool mostrou = false;

	void Start(){
		Game.tentativas = 0;
	}


	void Update () {
        if (!_init)
        {
            initializedCards();
            return;
        }
        
        if(!mostrou)
        {
            //StartCoroutine(VirarCartas(0));
            StartCoroutine( MostrarCartas(5) );

            mostrou = true;
        }
		

		if (Input.GetMouseButtonUp (0)) {
			checkCards ();
		}
	}

	void initializedCards(){
		for (int id = 0; id < 2; id++) {
			for( int i = 1 ; i < 4;i++){

				bool test = false;
				int choise = 0;

				while (!test) {
					choise = Random.Range (0, cards.Length);
					test = !(cards [choise].GetComponent<Card1> ().card.initialized);
				}
				cards [choise].GetComponent<Card1> ().card.cardValue = i;
				cards [choise].GetComponent<Card1> ().card.initialized = true;
			}
		}

        foreach (GameObject c in cards)
        {
            c.GetComponent<Card1>().setupGraphics();
            //c.GetComponent<Card1>().card.doNot = true;
        }
				

		if (!_init)
			_init = true;
	}

	public Sprite getCardBack(){
		return cardBack;
	}

	public Sprite getCardFace( int i){
		return cardFace[i - 1];
	}

	void checkCards(){
		List<int> c = new List<int> ();

		for (int i = 0; i < cards.Length; i++) {
			if (cards [i].GetComponent<Card1> ().card.state == 1) {
				c.Add(i);
			}
		}
		if (c.Count == 2) {
			cardComparison (c);
		}
	}


	void cardComparison(List<int> c){
		Card1 carda = gameObject.AddComponent<Card1>();
		carda.card.doNot = true;
		int x = 0;

		if (cards [c [0]].GetComponent<Card1> ().card.cardValue == cards [c [1]].GetComponent<Card1> ().card.cardValue) {
			x = 2;
			_matches--;
			matchText.text = " Número de Jogadas: " + _matches;
			print ("Tipo: " + MenuModel.tipos + "Nivel: " + MenuModel.subTipos);

			if (MenuModel.tipos == 1) {
				MenuModel.tipos = 1;
				MenuModel.subTipos = 1;
			} else if (MenuModel.tipos == 2) {
				MenuModel.tipos = 2;
				MenuModel.subTipos = 1;
			} else if (MenuModel.tipos == 3) {
				MenuModel.tipos = 3;
				MenuModel.subTipos = 1;

			}

			if (_matches == 0) {
				SceneManager.LoadScene ("Winner");
			}

		} else {
			Game.tentativas++;
			tentatitvasText.text = " Número de tentativas:  " + Game.tentativas;
		}

		for (int i = 0; i < c.Count; i++) {
			cards [c [i]].GetComponent<Card1> ().card.state = x;
			cards [c [i]].GetComponent<Card1> ().falseCheck ();
		}
    }

    IEnumerator MostrarCartas( int segundos )
    {
        foreach (GameObject c in cards)
            c.GetComponent<Card1>().flipCard();

        yield return new WaitForSeconds( segundos );

        foreach (GameObject c in cards)
        {
            c.GetComponent<Card1>().flipCard();
            c.GetComponent<Card1>().inicializada = true;
        }

    }
}
