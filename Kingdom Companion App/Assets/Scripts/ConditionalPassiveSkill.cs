using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ConditionalPassiveSkill : PassiveSkill {

	public abstract int ReceiveEffect (Stats currentStats);

	/*
	 * while MP < 1
	 * while HP < 30
	 * increases atk by one per hit in a combo
	 * increases atk by one per aerial hit in a combo
	 * upon lost initiative you may attack an opponent
	 * upon hit, you may counterattack
	 * upon guarded a hit, you may counterattack
	 * 
	*/

}