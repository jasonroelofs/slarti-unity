using UnityEngine;
using System.Collections;

public class ReceivesDamage : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		Debug.Log("[" + gameObject.name + "] I've been hit by a " + other.gameObject.name);

		DoesDamage doesDamage = other.GetComponent<DoesDamage>();

		if (doesDamage != null) {
			Debug.Log("[" + gameObject.name + "] ERMAGHERD! I TAKEZ DAMAGE -- " + doesDamage.DamagePacket.baseDamage);
			character.TakeDamage(doesDamage.DamagePacket);
		}
	}
}
