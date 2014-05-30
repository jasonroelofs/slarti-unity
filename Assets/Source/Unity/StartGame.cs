using UnityEngine;
using System.Collections;
using slarti;
using slarti.level;

namespace unity {
	public class StartGame : MonoBehaviour {

		public Game game;

		void Start () {
			game = new Game();
			game.Camera = GetComponentInChildren<Camera>().gameObject;
			game.LevelGenerator = BuildLevelGenerator();
			game.EntityGenerator = BuildEntityGenerator();
			game.Start();
		}

		void Update() {
			game.Update(Time.deltaTime);
		}

		LevelGenerator BuildLevelGenerator() {
			GameObject levelGenGO = new GameObject("Geometry Generator");
			levelGenGO.transform.parent = transform;
			GenerateGeometry geoGen = levelGenGO.AddComponent<GenerateGeometry>();

			return new LevelGenerator(geoGen as GeometryGenerator);
		}

		EntityGenerator BuildEntityGenerator() {
			GameObject entityGenGO = new GameObject("Entity Generator");
			entityGenGO.transform.parent = transform;
			GenerateEntity entityGen = entityGenGO.AddComponent<GenerateEntity>();
            
			return entityGen as EntityGenerator;
		}
	}
}
