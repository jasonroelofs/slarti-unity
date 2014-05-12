using UnityEngine;
using System.Collections;

public class WeaponView : MonoBehaviour {

	public Slarti.WeaponType weaponType;

	public Slarti.Weapon weapon;

	void Awake() {
		weapon = Slarti.WeaponFactory.BuildWeapon(weaponType);
	}

}
