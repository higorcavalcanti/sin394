using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class CardModel  {
	
	[SerializeField]
	private int _state;

	[SerializeField]
	private int _cardValue;

	[SerializeField]
	private bool _initialized = false;

	[SerializeField]
	private static bool _doNot = false;

	[SerializeField]
	private Sprite _cardBack;
	[SerializeField]
	private Sprite _cardFace;

	[SerializeField]
	private GameObject _manager;

	[SerializeField]
	private bool _ativo = false;


	public int cardValue {
		get{ return _cardValue; }
		set{ _cardValue = value; }
	}

	public int state {
		get{ return _state;  }
		set{ _state = value; }
	}

	public bool initialized {
		get{ return _initialized; }
		set{ _initialized = value;  }
	}

	public bool doNot {
		get{ return _doNot; }
		set{ _doNot = value;  }
	}

	public Sprite cardBack {
		get{ return _cardBack; }
		set{ _cardBack = value;  }
	}

	public Sprite cardFace {
		get{ return _cardFace; }
		set{ _cardFace = value;  }
	}


	public GameObject manager {
		get{ return _manager; }
		set{ _manager = value;  }
	}

	public bool ativo {
		get{ return _ativo; }
		set{ _ativo = value;  }
	}

}
