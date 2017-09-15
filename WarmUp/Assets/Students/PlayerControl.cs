using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour {

    public int myScore;
    Vector2 moveVector;

    public float forceMod;

    public Text scoreText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        float newX = Input.GetAxisRaw("Horizontal");
        Vector2 newForce = new Vector2(newX * forceMod, 0f);

        GetComponent<Rigidbody2D>().AddForce(newForce);
		
	}

    private void Update() {
        scoreText.text = myScore.ToString();
    }

    public void AddScore(int score) {
        myScore += score;
    }
}
