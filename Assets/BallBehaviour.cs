using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallBehaviour : MonoBehaviour {

	float powerResult;
	float defaultPowerx = 0f;
	float defaultPowery = 100f;
	float defaultPowerz = 500f;
	float powerX;
	float powerY;
	float powerZ;
	public Text powerZText;
	CameraController cc;
	HitBehaviour hb;
	// Use this for initialization
	void Start () {
		cc = GameObject.FindWithTag ("CameraController").GetComponent<CameraController> ();
		hb = GameObject.FindWithTag ("Club").GetComponent<HitBehaviour> ();
		powerResult = 0f;
		powerX = defaultPowerx;
		powerY = defaultPowery;
		powerZ = defaultPowerz;
		setPowerTextZ ();
	}

	void setPowerTextZ() {
		powerZText.text = "Power: " + powerZ.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			powerX = hb.getRotationX ();
			powerY = hb.getRotationY ();
			Debug.Log (powerX);
			Debug.Log (powerY);
			transform.GetComponent<Rigidbody> ().AddRelativeForce (new Vector3 (powerX, powerY + 100f, powerZ));
			cc.toggleCamera (1);
		}

		if (Input.GetKey (KeyCode.W) && powerZ < 1500) {
			powerZ += 5f;
			setPowerTextZ ();
		}
		if (Input.GetKey (KeyCode.S) && powerZ >= 0) {
			powerZ -= 5f;
			setPowerTextZ ();
		}
		/*
		if (Input.GetKey (KeyCode.A) && powerX >= -360) {
			powerX -= 3f;
			Debug.Log (powerX);
		}

		if (Input.GetKey (KeyCode.D) && powerX <= 360) {
			powerX += 3f;
		}

		if (Input.GetKey (KeyCode.UpArrow) && powerY <= 500) {
			powerY += 5f;
			Debug.Log (powerY);
		}

		if (Input.GetKey (KeyCode.DownArrow) && powerY <= 0) {
			powerY -= 5f;
		}

*/
	}
}
