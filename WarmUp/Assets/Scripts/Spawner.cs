using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	Sprite[] sprites;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SpawnSprite() {

		GameObject goSprite = new GameObject();
		goSprite.AddComponent<RigidBody2D>();
	
	}
}
