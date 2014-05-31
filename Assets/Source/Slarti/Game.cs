using UnityEngine;

namespace slarti {
	public class Game {
		public level.LevelGenerator LevelGenerator { get; set; }
		public level.EntityGenerator EntityGenerator { get; set; }
		public GameObject Camera { get; set; }

		public void Start() {
			LevelGenerator.GenerateLevel();

			EntityGenerator.PlaceEntity("Enemy", new Vector3(0, 1, 5));
			EntityGenerator.PlacePickup("Weapon", new Vector3(5, 1, 5));

			GameObject player = EntityGenerator.PlaceEntity("Player", new Vector3(0, 0, 0));

			Camera.SendMessage("TrackEntity", player, SendMessageOptions.RequireReceiver);
		}

		public void Update(float deltaT) {
		}
	}
}