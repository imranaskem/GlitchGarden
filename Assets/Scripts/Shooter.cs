using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public GameObject projectile;
	
	private GameObject projectileParent;
	
	void Start () {
		projectileParent = GameObject.Find ("Projectiles");
		
		if (!projectileParent) {
			projectileParent = new GameObject ("Projectiles");
		}
	}
	
	private void FireGun() {
		GameObject newProjectile = Instantiate (projectile) as GameObject;
		newProjectile.transform.position = transform.FindChild ("Gun").position;
		newProjectile.transform.parent = projectileParent.transform;
		
		
	}
	
	
}
