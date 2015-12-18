using UnityEngine;
using System.Collections;

public class DefenderSpawner : MonoBehaviour {
	
	private GameObject defParent;
	
	void Start () {
		defParent = GameObject.Find ("Defenders");
		
		if (!defParent) {
			defParent = new GameObject ("Defenders");
		}
	}
	
	void OnMouseDown () {
		Vector2 rawPos = CalculateWorldPointOfMouseClick ();
		Vector2 roundedPos = SnapToGrid (rawPos);
		GameObject newDef = Instantiate (Button.selectedDefender, roundedPos ,Quaternion.identity) as GameObject;
		newDef.transform.parent = defParent.transform;
	}
	
	Vector2 CalculateWorldPointOfMouseClick () {
		Vector2 worldPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);			
		return worldPos;
	}
	
	Vector2 SnapToGrid (Vector2 rawPos) {
		Vector2 mouseGrid;
		mouseGrid = new Vector2 (Mathf.RoundToInt (rawPos.x), Mathf.RoundToInt (rawPos.y));
		return mouseGrid;
	}
}
