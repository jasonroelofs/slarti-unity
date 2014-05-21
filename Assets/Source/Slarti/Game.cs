
namespace slarti {
	public class Game {
		public level.LevelGenerator LevelGenerator { get; set; }

		public void Start() {
			LevelGenerator.GenerateLevel();
		}

		public void Update(float deltaT) {
		}
	}
}