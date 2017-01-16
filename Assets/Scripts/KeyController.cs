using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour {

	public GameObject door;

	public void UnlockDoor () {
		door.SetActive (true);
		Destroy (gameObject);
	}
}
