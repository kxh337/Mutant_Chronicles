using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour {
	public float health;
	public float strength;
	public float speed;
	public float defense;
	public float stamina;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void recieveDmg(float dmg){
		dmg -= defense;
		health -= dmg;
	
	}

	public void attack(Unit enemy){
		bool crit=false;
		if(Random.Range(0,100)<25){
			crit = true;
		}
		float dmg  = (int)Random.Range(strength*.85f,strength*1.1f);
		if(crit){
			dmg = (int)(dmg * 1.5f);
		}
		enemy.recieveDmg(dmg);
	}



}

