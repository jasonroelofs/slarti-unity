using UnityEngine;
using System.Collections;

namespace unity {
	public class GenerateGeometry : MonoBehaviour, slarti.level.GeometryGenerator {

		#region GeometryGenerator implementation

		public void BuildPlaneAt(Vector3 location)
		{
			GameObject plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
			plane.transform.position = location;
		}

		#endregion


	}
}