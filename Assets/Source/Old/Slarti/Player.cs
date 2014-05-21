using System;

namespace Slarti
{
	public class Player
	{
		public Weapon currentWeapon {
			get;
			set;
		}

		public Player()
		{
		}

		public void StartFiringWeapon() {
			if (currentWeapon != null) {
				currentWeapon.StartFiring();
			}
		}

		public void StopFiringWeapon() {
			if (currentWeapon != null) {
				currentWeapon.StopFiring();
			}
		}
	}
}

