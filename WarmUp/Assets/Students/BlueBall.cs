using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBall : Ball {

   // public AudioClip clip;

    BlueBall() {
        myScore = 1;
        //impactSound = clip;
    }


    public override void Impact() {
        base.Impact();
        //AudioSource.PlayClipAtPoint(impactSound, transform.position, 0.2f);
        Debug.Log("BlueBall");  
    }
}
