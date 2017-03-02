using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClubBehaviour : MonoBehaviour {

	float rotationRate = 10f;
	GameController gc;
	GameController.Setup currentSetup;
	CameraController cc;
	void Start () {
		gc = GameObject.FindWithTag ("GameController").GetComponent<GameController>();
		cc = GameObject.FindWithTag ("CameraController").GetComponent<CameraController> ();
		GetComponent<ConstantForce> ().enabled = false;
		currentSetup = gc.getSetup ();
	}


	void OnCollisionEnter(Collision col) {
		if (col.gameObject.CompareTag("Ball")) {
			Destroy (gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (currentSetup == GameController.Setup.Angle) {
				gc.setSetupDrive ();
				currentSetup = GameController.Setup.Drive;
			} else {
				gc.setSetupAngle ();
				currentSetup = GameController.Setup.Angle;
			}
		}

		//Rotation
		if (currentSetup == GameController.Setup.Angle) {
			float horizontalAngle = Input.GetAxis("Mouse X");
			float verticalAngle = Input.GetAxis ("Mouse Y");
			float horizontalRotation = horizontalAngle * rotationRate * Time.deltaTime;
			float verticalRotation = verticalAngle * rotationRate * Time.deltaTime;
		//Quaternion target = Quaternion.Euler(0, horizontalRotation, 0);
		//transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
			transform.Rotate (verticalRotation, horizontalRotation, 0);
			//stick.transform.Rotate (verticalAngle, 0, 0);
		}
	}
}
