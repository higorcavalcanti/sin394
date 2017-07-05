using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class MenuModel  {


	[SerializeField]
	private static int _tipos = 0;

	[SerializeField]
	private static int _subTipos = 0;




	public static int tipos {
		get{ return _tipos; }
		set{ _tipos = value;  }
	}

	public static int subTipos {
		get{ return _subTipos; }
		set{ _subTipos = value;  }
	}


}
