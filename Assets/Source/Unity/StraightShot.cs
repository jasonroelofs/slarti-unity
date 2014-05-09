using UnityEngine;
using System.Collections;

public class StraightShot : MonoBehaviour {

	public float speed;
	public float lifeTime;
	
	void Start() {
		rigidbody.velocity = transform.forward * speed;
		Destroy(gameObject, lifeTime);
	}
}
