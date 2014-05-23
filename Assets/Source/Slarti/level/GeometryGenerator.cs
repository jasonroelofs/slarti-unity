namespace slarti.level {
	public interface GeometryGenerator {
		void BuildPlaneAt(UnityEngine.Vector3 location, float width, float height);

		void CreateDirectionalLight(UnityEngine.Quaternion rotation);
	}
}