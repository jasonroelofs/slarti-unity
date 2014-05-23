using UnityEngine;
using System.Collections;

public class TrackTarget : MonoBehaviour {

	private GameObject target;
	public Vector3 trackingOffset;
	public Vector3 trackingRotation;

	void Awake() {
		slarti.Events.instance.AddListener<slarti.events.TrackEntity>(StartTrackEntity);
	}

	void OnDestroy() {
		slarti.Events.instance.RemoveListener<slarti.events.TrackEntity>(StartTrackEntity);
	}

	public void StartTrackEntity(slarti.events.TrackEntity trackInfo) {
		target = trackInfo.target;
	}

	void LateUpdate () {
		if (target != null) {
			transform.position = target.transform.position + trackingOffset;
			transform.rotation = Quaternion.Euler(trackingRotation);
		}
	}
}
