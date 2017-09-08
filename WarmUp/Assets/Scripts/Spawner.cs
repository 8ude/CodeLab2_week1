using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public Sprite[] sprites;

    public int index;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnSprite", 0f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SpawnSprite() {

		GameObject goSprite = new GameObject();
        SpriteRenderer goRenderer = goSprite.AddComponent<SpriteRenderer>();
        goRenderer.sprite = sprites[index % sprites.Length];
        index++;
        goSprite.AddComponent<Rigidbody2D>();
	
	}
}
