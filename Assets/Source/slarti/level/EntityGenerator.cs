using UnityEngine;

namespace slarti.level
{
	public interface EntityGenerator {
		GameObject PlaceEntity(string entityName, Vector3 location);
		GameObject PlacePickup(string pickupName, Vector3 location);
	}

}

