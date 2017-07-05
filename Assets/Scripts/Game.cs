using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Game  {
	
	[SerializeField]
	private static float _horario = 0;

	[SerializeField]
	private static float _tentativas = 0;

	[SerializeField]
	private static float _hTotal = 0; 



	public static float tentativas {
		get{ return _tentativas; }
		set{ _tentativas = value;  }
	}

	public static float horario {
		get{ return _horario; }
		set{ _horario = value;  }
	}

	public static float hTotal {
		get { return _hTotal;}
		set {_hTotal = value ;}
	}
}
