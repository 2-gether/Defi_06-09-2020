using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject prefab;
	int offset;
	int length = 0;

	private void Awake() {
		offset = Mathf.RoundToInt(transform.position.x);
	}

	public void Instantiate() {
		Instantiate(prefab, new Vector3(length + offset, 0, 0), Quaternion.identity);
		length++;
	}
}
