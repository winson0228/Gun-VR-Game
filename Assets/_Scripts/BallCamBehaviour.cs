using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCamBehaviour : MonoBehaviour {

	private Vector3 offset;
	private Vector3 offset2;
	private GameObject ball;
	// Use this for initialization
	void Start () {
		ball = GameObject.FindWithTag ("Ball");
		offset = transform.position - ball.transform.position;
		offset2 = new Vector3 (0, 0, -2f);
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = ball.transform.position + offset;
	}
}
