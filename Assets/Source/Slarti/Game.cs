using UnityEngine;

namespace slarti {
	public class Game {
		public level.LevelGenerator LevelGenerator { get; set; }
		public level.EntityGenerator EntityGenerator { get; set; }
		public GameObject Camera { get; set; }

		public void Start() {
			LevelGenerator.GenerateLevel();
			EntityGenerator.PlaceEntity("Enemy", new UnityEngine.Vector3(0, 1, 5));
			GameObject player = EntityGenerator.PlaceEntity("Player", new UnityEngine.Vector3(0, 0, 0));

			Events.instance.Fire(new events.TrackEntity(player));
		}

		public void Update(float deltaT) {
		}
	}
}