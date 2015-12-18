using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StarDisplay : MonoBehaviour {

	private Text starText;
	private int totalStars;
	
	public enum Status {SUCCESS, FAILURE};
	
	void Start () {
		starText = GetComponent<Text>();
		totalStars = 100;
		UpdateDisplay ();
	}

	public void CollectStars (int amount) {
		totalStars += amount;
		UpdateDisplay ();		
	}
	
	public Status UseStars (int amount) {
		if (totalStars >= amount){
			totalStars -= amount;
			UpdateDisplay ();
			return Status.SUCCESS;
		} 
		return Status.FAILURE;
	}

	void UpdateDisplay ()
	{
		starText.text = totalStars.ToString ();
	}
}
