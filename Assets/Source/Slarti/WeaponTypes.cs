using System;

namespace Slarti
{
	public class WeaponTypes
	{
		public enum Types {
			SemiAuto,
			Unknown
		}

		public class NotImplementedWeaponTypeException : Exception { }

		public static Weapon BuildWeapon(Types weaponType) {
			if (weaponType == Types.SemiAuto) {
				return new SemiAutoWeapon();
			} else {
				throw new NotImplementedWeaponTypeException();
			}
		}
	}
}

