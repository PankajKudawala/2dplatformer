using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	
	public Transform target;
	public Vector3 offset;
	public float smoothSpeed = 0.5f;

	void Start(){

	}


	void FixedUpdate(){
		Vector3 newPos = target.position + offset;
		Vector3 smoothedPosition = Vector3.Lerp(transform.position, newPos, smoothSpeed);
		smoothedPosition.z = transform.position.z;
		transform.position = smoothedPosition;

	}
}
