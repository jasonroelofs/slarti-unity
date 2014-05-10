using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public GameObject currentWeaponPrefab;

	public Vector3 weaponPosition;
	public Vector3 weaponRotation;

	private Slarti.Player player;

	private GameObject currentWeapon;

	void Awake() {
		player = new Slarti.Player();
	}

	void Start() {
		GivePlayerWeapon();
	}

	void GivePlayerWeapon() {
		currentWeapon = Instantiate(currentWeaponPrefab, weaponPosition, Quaternion.Euler(weaponRotation)) as GameObject;
		currentWeapon.transform.parent = transform;

		player.currentWeapon = currentWeapon.GetComponent<WeaponView>().weapon;
    }

	public void StartFiringWeapon() {
		player.StartFiringWeapon();
	}

	public void StopFiringWeapon() {
		player.StopFiringWeapon();
	}
}

