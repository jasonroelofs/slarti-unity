using UnityEngine;
using System.Collections;

public class FireWeapon : MonoBehaviour {

	private PlayerController player;

	void Awake() {
		player = GameObject.FindGameObjectWithTag(Tags.player).GetComponent<PlayerController>();
	}

	void Update() {
		if (Input.GetButton("Fire1")) {
			player.FireWeapon();
		}
	}
}
