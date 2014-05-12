using System;

namespace Slarti {

	// WeaponView is the link between the back-end functionality of a given
	// weapon and said weapon's visual and interactive front-end.
	public interface WeaponView {

		// Fire sends off single shot of this weapon's set Ammo.
		void Fire(DamagePacket packet);
	}
}