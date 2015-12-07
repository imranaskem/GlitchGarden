using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsController : MonoBehaviour {

	public Slider volumeSlider;
	public Slider diffSlider;
	public LevelManager levelManager;
	
	private MusicManager musicManager;
	
	void Start () {
		musicManager = GameObject.FindObjectOfType<MusicManager>();
		
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume ();
		diffSlider.value = PlayerPrefsManager.GetDifficulty ();
		
	}
	
	void Update () {
		musicManager.ChangeVolume (volumeSlider.value);
	}
	
	public void SaveAndExit () {
		PlayerPrefsManager.SetMasterVolume (volumeSlider.value);
		PlayerPrefsManager.SetDifficulty (diffSlider.value);
		levelManager.LoadLevel ("01a_Start");
	}
	
	public void SetDefaults () {
		volumeSlider.value = 0.5f;
		diffSlider.value = 2f;
	}
}
