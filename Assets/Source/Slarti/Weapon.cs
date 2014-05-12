using System;

namespace Slarti {
	public interface Weapon {
		WeaponView View { get; set; }

		void StartFiring();
		void StopFiring();
	}
}
	