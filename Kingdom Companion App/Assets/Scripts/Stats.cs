using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats {

	public int dam = 10;
	public int maxHP = 10;
	public float curHP = 10;
	public int maxMP = 2;
	public float curMP = 2;
	public int atk = 0;
	public int def = 0;

	public Resistance myResistances;

	public Stats(int dam, int maxHP, int maxMP, int atk, int def){
		this.dam = dam;
		this.maxHP = maxHP;
		curHP = this.maxHP;
		this.maxMP = maxMP;
		curMP = this.maxMP;
		this.atk = atk;
		this.def = def;

		myResistances = new Resistance ();
	}

}