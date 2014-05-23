using UnityEngine;
using System.Collections;

namespace unity {
	public class StartGame : MonoBehaviour {

		public slarti.Game game;

		void Start () {
			game = new slarti.Game();
			game.Camera = GetComponentInChildren<Camera>().gameObject;
			game.LevelGenerator = BuildLevelGenerator();
			game.EntityGenerator = BuildEntityGenerator();
			game.Start();
		}

		void Update() {
			game.Update(Time.deltaTime);
		}

		slarti.level.LevelGenerator BuildLevelGenerator() {
			GameObject levelGenGO = new GameObject("Geometry Generator");
			levelGenGO.transform.parent = transform;
			GenerateGeometry geoGen = levelGenGO.AddComponent<GenerateGeometry>();

			return new slarti.level.LevelGenerator(geoGen as slarti.level.GeometryGenerator);
		}

		slarti.level.EntityGenerator BuildEntityGenerator() {
			GameObject entityGenGO = new GameObject("Entity Generator");
			entityGenGO.transform.parent = transform;
			GenerateEntity entityGen = entityGenGO.AddComponent<GenerateEntity>();
            
			return entityGen as slarti.level.EntityGenerator;
		}
	}
}
