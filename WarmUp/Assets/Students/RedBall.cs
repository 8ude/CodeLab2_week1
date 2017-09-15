using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBall : Ball {

	RedBall() {
		myScore = 3;
	}

	public override void Start() {
		base.Start();
		impactSound = Resources.Load("sound/stomp") as AudioClip;
	}

	public override void Impact() {
		Debug.Log("RedBall");
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 10f), ForceMode2D.Impulse);
	}
}
