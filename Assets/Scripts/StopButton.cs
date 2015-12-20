using UnityEngine;
using System.Collections;

public class StopButton : MonoBehaviour {

	private LevelManager lvlMan;
	
	// Use this for initialization
	void Start () {
		lvlMan = GameObject.FindObjectOfType<LevelManager>();
	}
	
	void OnMouseDown () {
		lvlMan.LoadLevel ("01a_Start");
	}
}
