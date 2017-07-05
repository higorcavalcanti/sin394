using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Card1 : MonoBehaviour {

	private float tempo;
    public bool inicializada = false;

	public CardModel card;
	//bool inicio;

	void Awake(){
		card = new CardModel();

	}

	void Start(){
		//inicio = true;
		card.state = 1;
		card.doNot = false;
		card.manager = GameObject.FindGameObjectWithTag("Manager");
		tempo = 0;
	}

	void Update(){
		//inicio = false;
		tempo += Time.deltaTime;
		if (tempo >= 2) {
			card.ativo = true;
		}
	}



	public void setupGraphics(){
		card.cardBack = card.manager.GetComponent<GameManager1> ().getCardBack ();
		card.cardFace = card.manager.GetComponent<GameManager1> ().getCardFace (card.cardValue);
		flipCard ();
	}


	public void flipCard(){
		if (card.state == 0) {
			card.state = 1;
		}
        else if(card.state == 1){
			card.state = 0;
		}

		if (card.state == 0 && !card.doNot) {
			GetComponent<Image> ().sprite = card.cardBack;
		}
        else if (card.state == 1 && !card.doNot) {
			GetComponent<Image> ().sprite = card.cardFace;
		}
	}

    public void onClick()
    {
        if(this.inicializada)
            this.flipCard();
    }




    public IEnumerator pause(){
		yield return new WaitForSeconds(0.5f);
		if (card.state == 0)
			GetComponent<Image> ().sprite = card.cardBack;
		else
			GetComponent<Image> ().sprite = card.cardFace;
		card.doNot = false;
	}

	public void falseCheck(){
		StartCoroutine (pause ());
	}


		
}
