using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VitalUIHandler : MonoBehaviour {

	public GameObject[] manaList;
	private List<GameObject> manaBallList = new List<GameObject>();
	public GameObject[] healthOpenList;
	public GameObject[] healthClosedList;

	// Use this for initialization
	void Start () {
		manaBallList = new List<GameObject>();
		foreach (GameObject go in manaList) {
			Transform[] temp = go.GetComponentsInChildren<Transform>();
			foreach (Transform t in temp) {
				if (t != go.transform) {
					manaBallList.Add (t.gameObject);
				}
			}
		}
	}

	public void AdjustMana(float curMana, float curMPBalls){
		for (int i = 0; i < manaList.Length; i++) {
			if (i < curMana) {
				manaList [i].SetActive (true);
			} else {
				manaList [i].SetActive (false);
			}
		}

		for (int i = 0; i < manaBallList.Count; i++) {
			if (i < curMPBalls) {
				manaBallList [i].SetActive (true);
			} else {
				manaBallList [i].SetActive (false);
			}
		}
	}

	public void AdjustHealth(float curHealth){
		for (int i = 0; i < healthOpenList.Length; i++) {
			if (i <= curHealth - 1) {
				if (i < curHealth - 1) {
					healthOpenList [i].SetActive (true);
					healthClosedList [i].SetActive (false);
				}else{
					healthOpenList [i].SetActive (false);
					healthClosedList [i].SetActive (true);
				}
			} else {
				healthOpenList [i].SetActive (false);
				healthClosedList [i].SetActive (false);
			}
		}
	}
}