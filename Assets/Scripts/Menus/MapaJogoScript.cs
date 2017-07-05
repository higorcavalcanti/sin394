using UnityEngine;
using System.Collections;

public class MapaJogoScript : MonoBehaviour {

	public static int level = 3;

    public Material locked;
    public Material unlocked;
    public Material complete;

    public GameObject level1;
    public GameObject level2;
    public GameObject level3;

	// Use this for initialization
	void Start () {
        if (level == 1)
        {
            this.level1.GetComponent<Renderer>().material = this.unlocked;
            this.level2.GetComponent<Renderer>().material = this.locked;
            this.level3.GetComponent<Renderer>().material = this.locked;
        }
        if (level == 2)
        {
            this.level1.GetComponent<Renderer>().material = this.complete;
            this.level2.GetComponent<Renderer>().material = this.unlocked;
            this.level3.GetComponent<Renderer>().material = this.locked;
        }
        if (level == 3)
        {
            this.level1.GetComponent<Renderer>().material = this.complete;
            this.level2.GetComponent<Renderer>().material = this.complete;
            this.level3.GetComponent<Renderer>().material = this.unlocked;
        }
    }
	
	// Update is called once per frame
	void Update () {

	}
}
