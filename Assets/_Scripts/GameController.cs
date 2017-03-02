using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public enum Setup { Angle, Drive };
	Setup stage;
	// Use this for initialization

	void Start () {
		stage = Setup.Angle;
	}

	public Setup getSetup() {
		return stage; 
	}

	public void setSetupAngle() {
		stage = Setup.Angle;
	}

	public void setSetupDrive() {
		stage = Setup.Drive;
	}

	void Update() {
		if (Input.GetKeyDown(KeyCode.R)) {
			Application.LoadLevel (Application.loadedLevel);
		}
	}

}
