using UnityEngine;
using System.Collections;

public class FixedFollow : MonoBehaviour {

	public GameObject target;
	public Vector3 offset;
	public Vector3 rotation;
	
	private Transform targetTransform;
	
	void Awake() {
		MatchTarget();
	}
	
	void FixedUpdate () {
		MatchTarget();
	}
	
	void MatchTarget() {
		transform.position = target.transform.position + offset;
		transform.rotation = Quaternion.Euler(rotation);
	}
}
