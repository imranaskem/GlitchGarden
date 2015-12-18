using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public float speed, damage;
	
	void Update () {
		transform.Translate (Vector3.right * speed * Time.deltaTime);
	}
	
	void OnTriggerEnter2D (Collider2D hit) {
		Health health = hit.GetComponent<Health>();
		if (hit.GetComponent<Attacker>() && health) {
			health.DealDamage (damage);
			Destroy (gameObject);
		}
	}
}
