using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	int bronze, silver, gold;
	float mineNow;
	float miningSpeed;
	public GameObject cubePrefab;
	GameObject myCube;
	Vector3 cubePos;
	float xPos, yPos;
	Color recentCubeColor;


	// Use this for initialization
	void Start () {
		bronze = 0;
		silver = 0;
		miningSpeed = 1;
		mineNow = miningSpeed;
		xPos = -5;
		yPos = -4;
		recentCubeColor = Color.red;
	}

	void SpawnCube (Color cubeColor) {
		cubePos = new Vector3 (xPos, yPos, 0);
		myCube = Instantiate (cubePrefab, cubePos, Quaternion.identity);
		myCube.GetComponent<Renderer> ().material.color = cubeColor;
		xPos += 2;
		if (xPos > 6) {
			xPos = -5;
			yPos += 2; // eventually this will go off screen
		}
		recentCubeColor = cubeColor;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > mineNow) {
			mineNow += miningSpeed;

			if (bronze == 2 && silver == 2 && recentCubeColor != Color.yellow) {
				gold++;
				SpawnCube (Color.yellow);
			}
			else if (bronze < 2) {
				bronze++;
				SpawnCube (Color.red);
			}
			else {
				silver++;
				SpawnCube (Color.white);
			}

			print ("Bronze: "+bronze+ " ... Silver: "+silver);
		}
	}
}
