using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {
	
	public AudioClip[] levelMusicChangeArray;
	
	private AudioSource music;
	
	private AudioClip currentPlaying;
	
	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad(gameObject);
	}
	
	void Start() {
		music = GetComponent<AudioSource>();
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
