using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {

	const string MASTER_VOL_KEY = "MasterVolume";
	const string DIFF_KEY = "Difficulty";
	const string LEVEL_KEY = "LevelUnlocked";

	public static void SetMasterVolume (float volume) {
		if (volume >= 0f && volume <= 1f) {
			PlayerPrefs.SetFloat (MASTER_VOL_KEY,volume);
		} else {
			Debug.LogError("Master Volume not valid");
		}
	}
	
	public static float GetMasterVolume () {
		return PlayerPrefs.GetFloat (MASTER_VOL_KEY);
	}
	
	public static void UnlockLevel (int level) {
		if (level <= Application.levelCount - 1) {
			PlayerPrefs.SetInt (LEVEL_KEY + level.ToString (),1);
		} else {
			Debug.LogError ("Level doesn't exist");
		}
	}
	
	public static bool IsLevelUnlocked (int level) {
		int levelValue = PlayerPrefs.GetInt (LEVEL_KEY + level.ToString ());
		bool isLevelUnlocked = (levelValue == 1);
		
		if (level <= Application.levelCount - 1) {
			return isLevelUnlocked;
		} else {
			Debug.LogError ("Queried level doesn't exist");
			return false;
		}
	}	
	
	public static void SetDifficulty (float diff) {
		if (diff >= 1f && diff <= 3f) {
			PlayerPrefs.SetFloat (DIFF_KEY,diff);
		} else {
			Debug.LogError ("Difficulty out of range");
		}
	}
	
	public static float GetDifficulty () {
		return PlayerPrefs.GetFloat (DIFF_KEY);
	}
}
