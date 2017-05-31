using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHover : MonoBehaviour {

	public void OnHoverOver(){
		transform.localScale = transform.localScale * 1.1f;
	}

	public void OnHoverExit(){
		transform.localScale = transform.localScale / 1.1f;
	}
}