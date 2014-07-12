using UnityEngine;
using System.Collections;

public class Hero : Unit {
	public float stamina;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void focus(){
		int recovery = (int)stamina/10;
		stamina += recovery;
		Mathf.Clamp(stamina,0,100);
	}

}
