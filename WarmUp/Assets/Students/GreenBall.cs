using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBall : Ball {

    //public AudioClip clip;

    GreenBall() {
        myScore = 2;
        //impactSound = clip;
    }

    public override void Start() {
        base.Start();
        impactSound = Resources.Load("sound/coin") as AudioClip;
    }


    public override void Impact() {
        base.Impact();
        AudioSource.PlayClipAtPoint(impactSound, transform.position, 0.2f);
        Debug.Log("GreenBall");
        Destroy(gameObject);
    }
}
