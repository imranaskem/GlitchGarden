using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadePanel : MonoBehaviour {

	public float fadeInTime;
	
	private Image fadePanel;
	private Color currentColour = Color.black;

	void Start () {
		fadePanel = GetComponent<Image>();	
	}
	
	void Update () {
		if (Time.timeSinceLevelLoad < fadeInTime) {
			float alphaChange = Time.deltaTime / fadeInTime;
			currentColour.a -= alphaChange;
			fadePanel.color = currentColour;
		} else {
			gameObject.SetActive (false);
		}
	}
}
