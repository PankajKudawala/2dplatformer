using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

	void Start () {
		
	}
	

	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "Player") {
			PlayerPrefs.SetInt("key",1);
			Destroy (gameObject);
		}
	}

}
