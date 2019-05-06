using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject key;

	void Start () {
		PlayerPrefs.SetInt("key",0);
	}

	void Update () {
		
	}
}
