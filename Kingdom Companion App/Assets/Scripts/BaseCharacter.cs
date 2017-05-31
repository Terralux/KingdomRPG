using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter {
	public Stats myStats;

	public BaseCharacter(int dam, int maxHP, int maxMP, int atk, int def){
		myStats = new Stats(dam, maxHP, maxMP, atk, def);
	}

	public void AdjustHealth(float adjustmentValue) {
		myStats.curHP += adjustmentValue;

		if (myStats.curHP <= 0) {
			myStats.curHP = 0;
			Debug.Log ("Player Died");
		}
		if (myStats.curHP > myStats.maxHP) {
			myStats.curHP = myStats.maxHP;
		}
	}

	public void AdjustMana(float adjustmentValue) {
		myStats.curMP += adjustmentValue;

		if (myStats.curMP <= 0) {
			myStats.curMP = 0;
			Debug.Log ("Player is out of Mana");
		}
		if (myStats.curMP > myStats.maxMP) {
			myStats.curMP = myStats.maxMP;
		}
	}

	public bool HasHealthEnough(int cost){
		if (cost >= myStats.curHP) {
			return false;
		} else {
			return true;
		}
	}

	public bool HasManaEnough(int cost){
		if (cost > myStats.curMP) {
			return false;
		} else {
			return true;
		}
	}
}