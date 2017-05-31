using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : BaseCharacter {
	public int exp;

	public List<Item> droplist = new List<Item>();

	public Enemy():base(1,10,1,1,1){
		
	}
}