using UnityEngine;
using NUnit.Framework;

namespace Slarti {

	[TestFixture] 
	public class PlayerTest {

		public Player player;

		[SetUp]
		public void CreatePlayer() {
			player = new Player();
		}

		[Test]
		public void PlayerStartsFiringCurrentWeapon() {
			TestWeapon weapon = new TestWeapon();

			player.currentWeapon = weapon;
			player.StartFiringWeapon();

			Assert.True(weapon.isFiring);
		}

		[Test]
		public void PlayerStopsFiringCurrentWeapon() {
			TestWeapon weapon = new TestWeapon();
			
			player.currentWeapon = weapon;
			player.StopFiringWeapon();
			
			Assert.False(weapon.isFiring);
		}

		[Test]
		public void IgnoresFireWeaponWhenNoWeaponEquipped() {
			player.StartFiringWeapon();
			player.StopFiringWeapon();
		}

	}

	public class TestWeapon : Weapon {
		public bool isFiring = false;

		public WeaponView View { get; set; }

		public void StartFiring() {
			isFiring = true;
		}

		public void StopFiring() {
			isFiring = false;
		}
	}
}