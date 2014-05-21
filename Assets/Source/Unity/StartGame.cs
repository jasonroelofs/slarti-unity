using UnityEngine;
using System.Collections;

namespace unity {
	public class StartGame : MonoBehaviour {

		public slarti.Game game;

		void Start () {
			game = new slarti.Game();
			game.LevelGenerator = BuildLevelGenerator();
			game.Start();
		}

		void Update() {
			game.Update(Time.deltaTime);
		}

		slarti.level.LevelGenerator BuildLevelGenerator() {
			GameObject levelGenGO = new GameObject();
			levelGenGO.transform.parent = transform;
			GenerateGeometry geoGen = levelGenGO.AddComponent<GenerateGeometry>();

			GameObject entityGenGO = new GameObject();
			entityGenGO.transform.parent = transform;
			GenerateEntity entityGen = entityGenGO.AddComponent<GenerateEntity>();
            
			return new slarti.level.LevelGenerator(
				geoGen as slarti.level.GeometryGenerator,
				entityGen as slarti.level.EntityGenerator
			);
		}


	}
}
