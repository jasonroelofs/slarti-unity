using UnityEngine;

namespace slarti.events {

	public class TrackEntity : Event {

		public GameObject target;

		public TrackEntity(GameObject target) {
			this.target = target;
		}
	}
}
