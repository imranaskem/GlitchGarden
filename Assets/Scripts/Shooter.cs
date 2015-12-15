using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public GameObject projectile, projectileParent;
	
	private void FireGun() {
		GameObject newProjectile = Instantiate (projectile) as GameObject;
		newProjectile.transform.position = transform.FindChild ("Gun").position;
		newProjectile.transform.parent = projectileParent.transform;
		
		
	}
	
	
}
