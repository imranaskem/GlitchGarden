using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameTimer : MonoBehaviour {

	public GameObject winText;
	public float endTimerInSeconds;
	
	private Slider slider;
	private AudioSource winClip;
	private LevelManager lvlMan;
	private bool isLevelOver = true;
	
	void Start () {
		slider = GetComponent<Slider>();
		slider.value = 0;
		slider.maxValue = endTimerInSeconds;
		winClip = winText.GetComponent<AudioSource>();
		lvlMan = FindObjectOfType<LevelManager>();
	}
	
	void Update () {
		slider.value = Time.timeSinceLevelLoad;
		if (WinCondition () && isLevelOver) {
			DestroyAllTaggedObjects ();
			winText.SetActive (true);
			PlayWinSound ();
			Invoke ("LoadLevel",winClip.clip.length);
			isLevelOver = false;
		}
	}
	
	void PlayWinSound () {
		winClip.volume = PlayerPrefsManager.GetMasterVolume ();
		winClip.Play ();
	}
	
	bool WinCondition () {
		if (slider.value == slider.maxValue) {
			return true;
		}
		return false;
	}

	void LoadLevel ()
	{
		lvlMan.LoadLevel ("03a_Win");
	}
	
	void DestroyAllTaggedObjects () {
		GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag ("DestroyOnWin");
		
		foreach (GameObject obj in taggedObjects) {
			Destroy (obj);
		}
	}
}
