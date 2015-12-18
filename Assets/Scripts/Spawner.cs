using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	
	public GameObject foxPrefab, lizardPrefab;
			
	void Update () {
		if (TimeToSpawn (foxPrefab)) {
			Spawn (foxPrefab);
		}
		
		if (TimeToSpawn (lizardPrefab)){
			Spawn(lizardPrefab);
		}
	}
	
	void Spawn (GameObject myGameObj) {
		GameObject newAtt = Instantiate (myGameObj, transform.position, Quaternion.identity) as GameObject;
		newAtt.transform.parent = transform;
		
	}
	
	bool TimeToSpawn (GameObject myGameObj) {
		float spawnTime = myGameObj.GetComponent<Attacker>().seenEverySeconds;
		float spawnPerSec = 1 / spawnTime;
		float threshold = spawnPerSec * Time.deltaTime / 5;
				
		if (Random.value < threshold) {
			return true;
		} else {
			return false;
		}
	}
}
