using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Attacker))]
public class Fox : MonoBehaviour {

	private Animator foxAnim;
	private Attacker attacker;
	
	void Start () {
		foxAnim = GetComponent<Animator>();
		attacker = GetComponent<Attacker>();
	}

	void OnTriggerEnter2D (Collider2D hit) {
		GameObject obj = hit.gameObject;
		if (hit.GetComponent<Stone>()){
			FoxJump (obj);
		} else {
			if (hit.GetComponent<Defender>()){
				FoxAttack (obj);
			}
		}
	}
	
	public void FoxJump (GameObject obj) {
		foxAnim.SetTrigger("jumpTrigger");
		attacker.Attack (obj);
	}
	
	public void FoxAttack (GameObject obj) {
		foxAnim.SetBool ("isAttacking", true);
		attacker.Attack (obj);
	}
}
