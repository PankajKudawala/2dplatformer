using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D coll){
		if (PlayerPrefs.GetInt ("key") == 1 && coll.gameObject.tag == "Player") {
			Debug.Log ("Stage Cleared");
		}
	}
}
