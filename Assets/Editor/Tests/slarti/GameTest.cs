using UnityEngine;
using NUnit.Framework;

namespace slarti {

	[TestFixture]
	public class GameTest {

		private Game game;

		[SetUp]
		public void CreateGame() {
			game = new Game();
		}

		[Test]
		public void Start_DoesSomething() {
			// Do nothing?
		}
	}
}
