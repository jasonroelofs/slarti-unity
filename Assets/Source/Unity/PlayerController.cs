using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Slarti.Player player;

	void Awake() {
		player = new Slarti.Player();
	}

	public void FireWeapon() {
		player.FireWeapon();
	}
}

