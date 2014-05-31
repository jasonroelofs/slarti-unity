using UnityEngine;
using System.Collections.Generic;

namespace slarti {
	public class Inventory {
		public List<GameObject> inventoryItems;

		public Inventory() {
			inventoryItems = new List<GameObject>();
		}

		public void Add(GameObject entity) {
			inventoryItems.Add(entity);
		}

		public List<GameObject> Entities() {
			return inventoryItems;
		}

		public void Empty() {
			inventoryItems.Clear();
		}
	}
}