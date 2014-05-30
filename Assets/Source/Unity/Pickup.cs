using UnityEngine;
using System.Collections;

/**
 * Turn the current item into something the player can obtain
 */
public class Pickup : MonoBehaviour {

	public float rotationSpeed;
	public float bobHeight;
	public float bobSpeed;

	private float currentBobbing;
	private Vector3 basePosition;

	void Start() {
		rotationSpeed = 75.0f;
		bobSpeed = 2.0f;
		bobHeight = 0.5f;
		currentBobbing = 0.0f;
		basePosition = transform.position;

		CapsuleCollider collider = gameObject.AddComponent<CapsuleCollider>();
		collider.height = 1;
		collider.radius = 1;
		collider.isTrigger = true;
	}

	void Update () {
		transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));

		currentBobbing += Time.deltaTime;
		transform.position = new Vector3(basePosition.x, basePosition.y + (Mathf.Cos(currentBobbing) * bobHeight), basePosition.z); 
	}

	void OnTriggerEnter(Collider collider) {
		Debug.Log("I've been hit!");
	}
}
