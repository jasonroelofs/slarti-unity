namespace slarti.level
{
	public class LevelGenerator
	{
		private GeometryGenerator geometryGenerator;
		private EntityGenerator entityGenerator;

		public LevelGenerator(GeometryGenerator geometryGenerator, EntityGenerator entityGenerator) {
			this.geometryGenerator = geometryGenerator;
			this.entityGenerator = entityGenerator;
		}

		public void GenerateLevel() {
			BuildGeometry();
			PlaceEnemies();
		}

		void BuildGeometry() {
			Logger.Info("Building Level Geometry");
			geometryGenerator.BuildPlaneAt(new UnityEngine.Vector3(0, 0, 0));
		}

		void PlaceEnemies() {
			Logger.Info("Placing an enemy");
			entityGenerator.PlaceEntity("Enemy", new UnityEngine.Vector3(0, 1, 0));
		}
	}
}

