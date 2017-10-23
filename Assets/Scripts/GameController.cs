using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	int bronze, bronzeSupply;
	int silver, silverSupply;
	float mineNow;
	float miningSpeed;
	public GameObject cubePrefab;
	GameObject myCube;
	Vector3 cubePos;
	float xPos;


	// Use this for initialization
	void Start () {
		bronze = 0;
		silver = 0;
		bronzeSupply = 3;
		silverSupply = 2;
		miningSpeed = 1;
		mineNow = miningSpeed;
		xPos = -5;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > mineNow) {
			mineNow += miningSpeed;

			if (bronzeSupply > 0) {
				bronzeSupply--;
				bronze++;

				cubePos = new Vector3 (xPos, 0, 0);
				myCube = Instantiate (cubePrefab, cubePos, Quaternion.identity);
				myCube.GetComponent<Renderer> ().material.color = Color.red;
				xPos += 2;

			}
			else if (silverSupply > 0) {
				silverSupply--;
				silver++;

				cubePos = new Vector3 (xPos, 0, 0);
				myCube = Instantiate (cubePrefab, cubePos, Quaternion.identity);
				myCube.GetComponent<Renderer> ().material.color = Color.white;
				xPos += 2;

			}

			print ("Bronze: "+bronze+ " ... Silver: "+silver);
		}
	}
}
