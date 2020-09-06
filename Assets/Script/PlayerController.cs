using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	void Update() {
		if(Input.GetKeyDown(KeyCode.Space)) {
			GetComponent<Rigidbody>().AddForce(new Vector3(0, 12, 0), ForceMode.Impulse);
		}
	}
}
