using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {
	
	public AudioClip[] levelMusicChangeArray;
	
	private AudioSource music;
	
	private AudioClip currentPlaying;
	
	void Awake () {
		DontDestroyOnLoad(gameObject);
	}
	
	void Start() {
		music = GetComponent<AudioSource>();
		music.volume = PlayerPrefsManager.GetMasterVolume ();
	}
	
	public void ChangeVolume (float volume) {
		music.volume = volume;
	}
	
	void OnLevelWasLoaded (int level) {
		AudioClip levelMusic = levelMusicChangeArray[level];
		
		if (levelMusic && levelMusic != currentPlaying) {
			currentPlaying = levelMusic;
			music.clip = levelMusic;
			music.loop = true;
			music.Play ();
		}
	}
}
