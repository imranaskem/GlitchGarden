using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public GameObject projectile;
	
	private GameObject projectileParent;
	private Animator anim;
	private Spawner myLaneSpawner;
	
	void Start () {
		SetMyLaneSpawner ();
		
		anim = GetComponent<Animator>();
		
		projectileParent = GameObject.Find ("Projectiles");
		
		if (!projectileParent) {
			projectileParent = new GameObject ("Projectiles");
		}
	}
	
	void Update () {
		if (IsAttackerAheadInLane ()){
			anim.SetBool ("isAttacking", true);
		} else {
			anim.SetBool ("isAttacking", false);
		}
	}
	
	private void FireGun() {
		GameObject newProjectile = Instantiate (projectile) as GameObject;
		newProjectile.transform.position = transform.FindChild ("Gun").position;
		newProjectile.transform.parent = projectileParent.transform;
	}
	
	bool IsAttackerAheadInLane () {
		if (myLaneSpawner.transform.childCount <= 0) {
			return false;
		}
		
		foreach(Transform attacker in myLaneSpawner.transform) {
			if (attacker.transform.position.x > transform.position.x) {
				return true;
			} 
		}
		return false;
	}
	
	void SetMyLaneSpawner () {
		Spawner[] allLaneSpawners = FindObjectsOfType<Spawner>();
		
		foreach(Spawner laneSpawner in allLaneSpawners) {
			if (laneSpawner.transform.position.y == transform.position.y) {
				myLaneSpawner = laneSpawner;
			}
		}
		
		if (!myLaneSpawner) {
			Debug.LogError ("No spawner set");
		}
	}
	
	
}
