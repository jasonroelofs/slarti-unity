using UnityEngine;
using System.Collections;

public class StraightShot : MonoBehaviour {

	public float speed;
	public float lifeTime;
	
	void Start() {
		rigidbody.velocity = transform.forward * speed;
		Destroy(gameObject, lifeTime);
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log("["+ gameObject.name +"] I hit something [" + other.gameObject.name + "], die!");
		Destroy(gameObject);
	}
}
