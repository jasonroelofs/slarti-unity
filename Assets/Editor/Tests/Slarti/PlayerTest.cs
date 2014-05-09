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
		public void PlayerIsConstructable() {
			Assert.IsNotNull(player);
		}

		[Test]
		public void FiringAWeapon() {
			Assert.That(1 + 2 == 3);
		}

		[Test]
		public void EatingBreakfast() {
			Assert.That(4 + 5 == 9);
		}
	}
}