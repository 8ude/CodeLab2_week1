using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBall : Ball {

    //AudioClip yellowClip;

    YellowBall() {
        myScore = -1;
    }

	public override void Start() {
		base.Start();
		impactSound = Resources.Load("sound/bumpwall") as AudioClip;
	}

    public override void Impact() {
        Debug.Log("YellowBall");
        base.Impact();
        AudioSource.PlayClipAtPoint(impactSound, transform.position, 0.2f);
    }
}
