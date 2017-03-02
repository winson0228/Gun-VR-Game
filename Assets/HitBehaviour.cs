using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBehaviour : MonoBehaviour {
	GameController gc;
	GameController.Setup currentSetup;
	CameraController cc;
	float rotationRate = 10f;
	// Use this for initialization
	void Start () {
		gc = GameObject.FindWithTag ("GameController").GetComponent<GameController>();
		cc = GameObject.FindWithTag ("CameraController").GetComponent<CameraController> ();
		currentSetup = gc.getSetup ();
	}

	public float getRotationX() {
		return transform.eulerAngles.x;
	}
	public float getRotationY() {
		return transform.eulerAngles.y;
	}
	public float getRotationZ() {
		return transform.eulerAngles.z;
	}
	
	// Update is called once per frame
	void Update () {
		if (currentSetup == GameController.Setup.Angle) {
			float horizontalAngle = Input.GetAxis ("Mouse X");
			float verticalAngle = Input.GetAxis ("Mouse Y");
			float horizontalRotation = horizontalAngle * rotationRate * Time.deltaTime;
			float verticalRotation = verticalAngle * rotationRate * Time.deltaTime;
			transform.Rotate (verticalRotation, horizontalRotation, 0);
		}
	}
}
