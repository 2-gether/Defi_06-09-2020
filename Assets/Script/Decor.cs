using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decor : MonoBehaviour {

	GameManager gameManager;
	[SerializeField, Min(0f)] float baseSpeed = 0.5f;

	void Awake() {
		gameManager = GameManager.Instance;
	}

	void FixedUpdate() {
		transform.Translate(-baseSpeed * gameManager.Speed, 0, 0);
	}
}
