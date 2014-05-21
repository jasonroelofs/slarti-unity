using UnityEngine;
using System.Collections;

public class FireWeapon : MonoBehaviour {

	private PlayerController playerController;
	private bool firing;

	void Awake() {
		playerController = GameObject.FindGameObjectWithTag(Tags.player).GetComponent<PlayerController>();
		firing = false;
	}

	void Update() {
		if (!firing && Input.GetButton("Fire1")) {
			firing = true;
			playerController.StartFiringWeapon();
		}

		if (firing && Input.GetButtonUp("Fire1")) {
			firing = false;
			playerController.StopFiringWeapon();
		}
	}
}
