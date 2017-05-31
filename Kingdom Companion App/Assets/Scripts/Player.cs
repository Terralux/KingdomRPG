using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : BaseCharacter {
	public string name;
	public Sprite icon;

	public int level;
	public int exp;
	public int tnl;

	public int AP;
	public int curAP;

	public int maxDriveBars;
	public float currentDrive;
	public float currentMPBalls;

	public uint HITs = 3;
	public bool hasFinisher = true;

	public List<Skill> skills = new List<Skill>();

	public Player():base (1,18,9,1,1){
		name = "Chosen";
		level = 1;
		exp = 0;
		tnl = (int)(10 * Mathf.Pow ((float)level, 1.1f)) - exp;
		AP = 1;
		curAP = AP;
		maxDriveBars = 3;
		currentDrive = 0;
	}

	public void PickupBall(BallType myBallType){
		switch(myBallType){
		case BallType.HEALTH:
			AdjustHealth (Random.Range(0.1f, 0.3f));
			break;
		case BallType.MANA:
			currentMPBalls += Random.Range (0.1f, 0.3f);
			if (currentMPBalls >= myStats.curMP * 9) {
				currentMPBalls = 0;
				AdjustMana (1);
			}
			break;
		case BallType.DRIVE:
			AdjustDrive (Random.Range (0.1f, 0.3f));
			break;
		}
	}

	public void AdjustDrive(float adjustmentValue){
		currentDrive += adjustmentValue;

		if (currentDrive < 0) {
			currentDrive = 0;
		}
		if (currentDrive > maxDriveBars) {
			currentDrive = maxDriveBars;
		}
	}
}

public enum BallType{
	HEALTH,
	MANA,
	DRIVE
}