using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {

	private GameObject currentTarget;
	private float moveSpeed;
	private Animator anim;
	
	void Start () {
		Rigidbody2D myRigidBody = gameObject.AddComponent<Rigidbody2D>();
		myRigidBody.isKinematic = true;
		anim = GetComponent<Animator>();
	}
	
	void Update () {
		transform.Translate (Vector3.left * moveSpeed * Time.deltaTime);
	}
	
	void OnTriggerEnter2D () {
		//Debug.Log (name + " triggered");
	}
	
	public void SetSpeed (float speed) {
		moveSpeed = speed;
	}
	
	public void StrikeCurrentTarget (float damage) {
		if (currentTarget) {
			Health health = currentTarget.GetComponent<Health>();
			if (health) {
				health.DealDamage (damage);
			}
		} else {
			anim.SetBool ("isAttacking", false);
		}
	}
	
	public void Attack (GameObject obj) {
		currentTarget = obj;
	}
}
