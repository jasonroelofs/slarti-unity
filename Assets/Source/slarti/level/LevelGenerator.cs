using UnityEngine;

namespace slarti.level
{
	public class LevelGenerator
	{
		private GeometryGenerator geometryGenerator;

		public LevelGenerator(GeometryGenerator geometryGenerator) {
			this.geometryGenerator = geometryGenerator;
		}

		public void GenerateLevel() {
			BuildGeometry();
			SetLighting();
		}

		void BuildGeometry() {
			Logger.Info("Building Level Geometry");
			geometryGenerator.BuildPlaneAt(new Vector3(0, 0, 0), 5, 5);
		}

		void SetLighting() {
			geometryGenerator.CreateDirectionalLight(Quaternion.Euler(new Vector3(45, 45, 0)));
		}
	}
}

