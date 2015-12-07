using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadePanel : MonoBehaviour {

	public float fadeInTime;
	
	private Image fadePanel;
	private Color currentColour = Color.black;

	void Start () {
		fadePanel = GetComponent<Image>();
		fadePanel.color = currentColour;
		fadePanel.CrossFadeAlpha(0f,fadeInTime,true);
		Invoke("Disable", fadeInTime);
	}
	
	void Disable () {
		fadePanel.enabled = false;
	}
}
