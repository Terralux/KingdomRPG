using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsUIHandler : MonoBehaviour {

	public Text currentHP;
	public Text currentMP;
	public Text currentAP;

	public Text maxHP;
	public Text maxMP;
	public Text maxAP;

	public Text atkField;
	public Text defField;
	public Text lvField;
	public Text expField;

	public Text tnlField;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void UpdateStats(Player player){
		currentHP.text = player.myStats.curHP.ToString();
		currentMP.text = player.myStats.curMP.ToString();
		currentAP.text = player.curAP.ToString();

		maxHP.text = player.myStats.maxHP.ToString();
		maxMP.text = player.myStats.maxMP.ToString();
		maxAP.text = player.AP.ToString();

		atkField.text = player.myStats.atk.ToString();
		defField.text = player.myStats.def.ToString();
		lvField.text = player.level.ToString();
		expField.text = player.exp.ToString();

		tnlField.text = player.tnl.ToString();
	}

}