using System;

namespace Slarti
{
	public class SemiAutoWeapon : Weapon
	{
		private bool canFireAgain = true;

		#region Weapon implementation
		public WeaponView View { get; set; }

		public void StartFiring()
		{
			if (canFireAgain) {
				canFireAgain = false;
				DamagePacket packet = new DamagePacket();
				View.Fire(packet);
			}
		}

		public void StopFiring()
		{
			canFireAgain = true;
		}
		#endregion

	}

}

