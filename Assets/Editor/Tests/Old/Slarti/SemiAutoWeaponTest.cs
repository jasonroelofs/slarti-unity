using UnityEngine;
using NUnit.Framework;
using System.Collections.Generic;

namespace Slarti {
	
	[TestFixture] 
	public class SemiAutoWeaponTest {
		
		public SemiAutoWeapon weapon;
		
		[SetUp]
		public void CreatePlayer() {
			weapon = new SemiAutoWeapon();
		}

		[Test]
		public void FiresOneShotPerStartStopCycle() {
			TestWeaponView testView = new TestWeaponView();
			weapon.View = testView;

			weapon.StartFiring();
			weapon.StartFiring();
			weapon.StopFiring();

			Assert.That(testView.packetsFired.Count == 1);

			weapon.StartFiring();

			Assert.That(testView.packetsFired.Count == 2);
        }

	}

	class TestWeaponView : WeaponView {
		public List<DamagePacket> packetsFired;

		public TestWeaponView() {
			packetsFired = new List<DamagePacket>();
		}

		#region WeaponView implementation
		public void Fire(DamagePacket packet)
		{
			packetsFired.Add(packet);
		}
		#endregion
	}

}

