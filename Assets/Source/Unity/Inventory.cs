using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {
	
	public slarti.Inventory inventory;

	void Start() {
		inventory = new slarti.Inventory();
	}

	void OnDestroy() {
		DropAllItems();
	}

	public void PickUp(GameObject entity) {
		Debug.Log("Picking up something: " + entity.name);
		entity.transform.parent = transform;
		entity.transform.localPosition = new Vector3(0, 0, 0);
		entity.SetActive(false);

		inventory.Add(entity);
	}

	void DropAllItems() {
		foreach(GameObject entity in inventory.Entities()) {
			entity.transform.parent = null;
			entity.AddComponent<Pickup>();
			entity.SetActive(true);
		}

		inventory.Empty();
	}
}
