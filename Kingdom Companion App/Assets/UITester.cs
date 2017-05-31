using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITester : MonoBehaviour {

	public VitalUIHandler vh;
	public StatsUIHandler sh;
	private Player myPlayer;

	// Use this for initialization
	void Start () {
		myPlayer = new Player ();
		vh.AdjustHealth (myPlayer.myStats.curHP);
		vh.AdjustMana (myPlayer.myStats.curMP, myPlayer.currentMPBalls);
		sh.UpdateStats (myPlayer);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			myPlayer.AdjustHealth (1);
			vh.AdjustHealth (myPlayer.myStats.curHP);
			sh.UpdateStats (myPlayer);
			Debug.Log (myPlayer.myStats.curHP);
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			myPlayer.AdjustHealth (-1);
			vh.AdjustHealth (myPlayer.myStats.curHP);
			sh.UpdateStats (myPlayer);
			Debug.Log (myPlayer.myStats.curHP);
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			myPlayer.AdjustMana (1);
			vh.AdjustMana (myPlayer.myStats.curMP, myPlayer.currentMPBalls);
			sh.UpdateStats (myPlayer);
			Debug.Log (myPlayer.myStats.curMP + " : " + myPlayer.currentMPBalls);
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			myPlayer.AdjustMana (-1);
			vh.AdjustMana (myPlayer.myStats.curMP, myPlayer.currentMPBalls);
			sh.UpdateStats (myPlayer);
			Debug.Log (myPlayer.myStats.curMP + " : " + myPlayer.currentMPBalls);
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			myPlayer.PickupBall (BallType.MANA);
			vh.AdjustMana (myPlayer.myStats.curMP, myPlayer.currentMPBalls);
			sh.UpdateStats (myPlayer);
			Debug.Log (myPlayer.myStats.curMP + " : " + myPlayer.currentMPBalls);
		}
	}
}