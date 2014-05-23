using UnityEngine;
using System.Collections;

public class CardinalMovement : MonoBehaviour {
	
	public float movementSpeed = 5f;
	
	void FixedUpdate() {
		Vector3 current = rigidbody.velocity;
		float vertical = Input.GetAxis("Vertical");
		float horizontal = Input.GetAxis("Horizontal");
		
		rigidbody.velocity = new Vector3(horizontal * movementSpeed, current.y, vertical * movementSpeed);
	}
}
