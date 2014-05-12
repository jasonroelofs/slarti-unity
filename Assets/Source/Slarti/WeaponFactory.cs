using System;

namespace Slarti
{
	public class WeaponFactory
	{


		public class NotImplementedWeaponTypeException : Exception { }

		public static Weapon BuildWeapon(WeaponType weaponType) {
			switch (weaponType) {
				case WeaponType.SemiAuto:
					return new SemiAutoWeapon();
				default:
					throw new NotImplementedWeaponTypeException();
			}
		}
	}
}

