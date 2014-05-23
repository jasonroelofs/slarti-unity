using UnityEngine;
using System.Collections;

public class GenerateEntity : MonoBehaviour, slarti.level.EntityGenerator {

	private Hashtable knownEntities;

	void Awake() {
		knownEntities = new Hashtable();
		GameObject[] entityPrefabs = Resources.LoadAll<GameObject>("Entities");
		foreach (GameObject prefab in entityPrefabs) {
			Debug.Log("Loading prefab " + prefab.name);
			knownEntities.Add(prefab.name, prefab);
		}
	}

	#region EntityGenerator implementation

	public GameObject PlaceEntity(string entityName, Vector3 location)
	{
		GameObject entityPrefab = knownEntities[entityName] as GameObject;
		if (entityPrefab != null) {
			GameObject entity = Instantiate(entityPrefab, location, Quaternion.identity) as GameObject;
			entity.transform.parent = transform;
			return entity;
		} else {
			Debug.LogWarning(
				string.Format("Trying to instantiate entity {} but no such prefab exists", entityName)
			);
		}

		return null;
	}

	#endregion


}
