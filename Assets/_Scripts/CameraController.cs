using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	GameObject[] cameras;
	int activeCam;
	// Use this for initialization
	void Start () {
		cameras = new GameObject[2];
		cameras [0] = GameObject.FindWithTag ("MainCamera");
		cameras [1] = GameObject.FindWithTag ("BallCamera");
		//activeCam = 0;
		cameras [1].active = false;
	}

	public void toggleCamera(int num) {
		for (int i = 0; i < cameras.Length; i++) {
			if (i == num) {
				cameras [activeCam].active = false;
				cameras [i].active = true;
				activeCam = i;
			} 
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.V)) {
			if (activeCam == 1) {
				toggleCamera (0);
			} else {
				toggleCamera (1);
			}
		}
	}
}
