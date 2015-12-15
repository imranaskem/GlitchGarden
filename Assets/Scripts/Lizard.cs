using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Attacker))]
public class Lizard : MonoBehaviour {

	private Animator lizardAnim;
	private Attacker attacker;
	
	void Start () {
		lizardAnim = GetComponent<Animator>();
		attacker = GetComponent<Attacker>();
	}
	
	void OnTriggerEnter2D (Collider2D hit) {
		GameObject obj = hit.gameObject;
		if (hit.GetComponent<Defender>()){
			LizardAttack(obj);
		}
	}
	
	public void LizardAttack (GameObject obj) {
		lizardAnim.SetBool ("isAttacking", true);
		attacker.Attack (obj);
	}
}
