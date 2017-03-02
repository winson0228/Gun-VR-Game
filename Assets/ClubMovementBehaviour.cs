using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClubMovementBehaviour : MonoBehaviour {

	private Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.parent.position - transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = transform.parent.position + offset;
	}
}
