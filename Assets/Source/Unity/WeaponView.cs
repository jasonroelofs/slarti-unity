using UnityEngine;
using System.Collections;

public class WeaponView : MonoBehaviour {

	public Slarti.WeaponTypes.Types weaponType;

	public Slarti.Weapon weapon;

	void Awake() {
		weapon = Slarti.WeaponTypes.BuildWeapon(weaponType);
	}

}
