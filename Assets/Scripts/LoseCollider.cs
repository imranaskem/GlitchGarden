using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	public int numOfExits;
	
	private LevelManager levelMan;
	
	void Start () {
		levelMan = FindObjectOfType<LevelManager>();
	}
			
	void OnTriggerEnter2D (Collider2D col) {
		numOfExits -= 1;
		Destroy (col.gameObject);
		
		if (numOfExits == 0) {
			levelMan.LoadLevel ("03b_Lose");
		}
	}
}
