using UnityEngine;
using System.Collections;

public class LookAtMouse : MonoBehaviour {

	public Camera mainCamera;
	
	void Update() {
		Ray screenToPoint = mainCamera.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		
		if (Physics.Raycast(screenToPoint, out hit)) {
			LookInDirectionOfPoint(hit.point);
		}
	}
	
	void LookInDirectionOfPoint(Vector3 point) {
		point.y = transform.position.y;
		transform.LookAt(point, Vector3.up);
	}
}