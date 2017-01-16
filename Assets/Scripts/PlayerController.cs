using UnityEngine;

public class PlayerController : MonoBehaviour
{
	void Update()
	{
		processmovement();

	}
	void processmovement ()
	{
		var x = Input.GetAxis("Mouse X") * Time.deltaTime * 150.0f; 	//mouse is getting left and right movement
		var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f; 		//ws & arrow keys getting forward and backward movement

		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);
	}

	void OnTriggerEnter(Collider other) { 
		KeyController kc = other.GetComponent<KeyController>();
		if (kc) {
			kc.UnlockDoor ();
			return;
		}
	}
}