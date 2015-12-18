﻿using UnityEngine;
using System.Collections;

public class Defender : MonoBehaviour {

	public int starCost;
	private StarDisplay starDisplay;
	
	void Start () {
		starDisplay = FindObjectOfType<StarDisplay>();
	}
	
	public void AddStars (int amount) {
		starDisplay.CollectStars (amount);
	}
}
