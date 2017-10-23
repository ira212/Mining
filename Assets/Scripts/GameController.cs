using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	bool printNow;

	// Use this for initialization
	void Start () {
		printNow = true;
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time > 3 && printNow) {
			print ("It's been 3 seconds!");
			printNow = false;
		}
		
	}
}
