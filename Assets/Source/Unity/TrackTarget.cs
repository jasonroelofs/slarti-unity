using UnityEngine;
using System.Collections;

public class TrackTarget : MonoBehaviour {

	private GameObject target;
	public Vector3 trackingOffset;
	public Vector3 trackingRotation;
	
	void TrackEntity(GameObject toTrack) {
		target = toTrack;
	}

	void LateUpdate () {
		if (target != null) {
			transform.position = target.transform.position + trackingOffset;
			transform.rotation = Quaternion.Euler(trackingRotation);
		}
	}
}
