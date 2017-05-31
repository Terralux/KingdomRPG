using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : Item {
	public Stats myStatBuffs;
	public int AP;
	public Resistance myResistance;
	public List<Skill> mySkills = new List<Skill>();
	public float expModifier;
}