using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball: MonoBehaviour{

    public int myScore;

    public AudioClip impactSound;

    GameObject playerObject;

    public virtual void Start() {
        playerObject = GameObject.FindWithTag("Player");

    }

    public virtual void Impact() {
        
        playerObject.GetComponent<PlayerControl>().AddScore(myScore);
    } 

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Player") {
            Impact();
        }
    }
}
