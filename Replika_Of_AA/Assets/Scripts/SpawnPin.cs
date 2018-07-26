using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPin : MonoBehaviour {

	public GameObject pinPrefab;

	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			spawnPin ();
		}
		
	}
	void spawnPin()
	{
		Instantiate (pinPrefab, transform.position, transform.rotation);
	}
}
