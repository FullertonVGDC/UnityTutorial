using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	public Transform character;

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(character.position.x, character.position.y,0);
	}
}
