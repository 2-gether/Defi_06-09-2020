using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	public Spawner spawner;

	private void OnCollisionEnter(Collision collision) {
		if(collision.collider.gameObject.layer == LayerMask.NameToLayer("Ground")) {
			Destroy(collision.collider.gameObject);
			spawner.Instantiate();
		}
	}
}
