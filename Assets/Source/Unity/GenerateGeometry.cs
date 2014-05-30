using UnityEngine;
using System.Collections;

public class GenerateGeometry : MonoBehaviour, slarti.level.GeometryGenerator {

	#region GeometryGenerator implementation

	public void BuildPlaneAt(Vector3 location, float width, float height)
	{
		GameObject plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
		plane.transform.parent = transform;
		plane.transform.position = location;
		plane.transform.localScale = new Vector3(width, 1, height);
	}

	public void CreateDirectionalLight(Quaternion rotation)
	{
		GameObject light = new GameObject("Sun");
		Light lightComponent = light.AddComponent<Light>();
		light.transform.parent = transform;
		light.transform.rotation = rotation;

		lightComponent.type = LightType.Directional;
		lightComponent.shadows = LightShadows.Soft;
		lightComponent.intensity = 0.3f;
	}

	#endregion


}