using UnityEngine;
using System.Collections;

public class WeaponView : MonoBehaviour, Slarti.WeaponView {

	public Slarti.WeaponType weaponType;
	public GameObject ammo;

	[HideInInspector]
	public Slarti.Weapon weapon;

	private Transform firePoint;

	void Awake() {
		BuildWeapon();
		FindFirePointChild();
	}

	void BuildWeapon() {
		weapon = Slarti.WeaponFactory.BuildWeapon(weaponType);
		weapon.View = this;
	}

	void FindFirePointChild() {
		foreach (Transform child in transform) {
			if (child.gameObject.tag == Tags.firePoint) {
				firePoint = child;
				break;
			}
		}
		
		if (firePoint == null) {
			Debug.LogWarning("No FirePoint found in the children of " + gameObject.name + "! Tag the FirePoint GO.");
		}
	}

	#region WeaponView implementation
	public void Fire(Slarti.DamagePacket packet)
	{
		Instantiate(ammo, firePoint.position, firePoint.rotation);
	}
	#endregion
}
