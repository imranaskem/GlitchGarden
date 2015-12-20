using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Button : MonoBehaviour {

	private Button[] buttonArray;
	private Text costText;
	private int defCost;
	
	public GameObject defenderPrefab;	
	public static GameObject selectedDefender;
	
	// Use this for initialization
	void Start () {
		buttonArray = GameObject.FindObjectsOfType<Button>();
		costText = GetComponentInChildren<Text>();
		if (!costText) {
			Debug.LogWarning ("Can't find text element");
		}
		defCost = defenderPrefab.GetComponent<Defender>().starCost;
		costText.text = defCost.ToString ();
	}
	
	void OnMouseDown () {		
		foreach(Button thisButton in buttonArray) {
			thisButton.GetComponent<SpriteRenderer>().color = Color.black;	
		}
		
		GetComponent<SpriteRenderer>().color = Color.white;
		
		selectedDefender = defenderPrefab;
		
		
	}
}
