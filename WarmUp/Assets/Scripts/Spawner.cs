using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public Sprite redBallSprite, greenBallSprite, blueBallSprite, yellowBallSprite;
    float spawnPerSecondRate = 2f;
    float timeSinceSpawn;
    float minSpawnTime = 0.3f;

    public GameObject generiBall;

    public Vector2 minBound;
    public Vector2 maxBound;

	// Use this for initialization
	void Start() {
        SpriteTime();
		InvokeRepeating("SpriteTime", 1, 1);
	}

	// Update is called once per frame
	void Update() {
        timeSinceSpawn += Time.deltaTime;
        if (timeSinceSpawn >= spawnPerSecondRate) {
            timeSinceSpawn = 0f;
            SpriteTime();
        }
	}

	void SpriteTime() {
		int nextNum = GetComponent<NumberGenerator>().Next();

		MakeSprite(nextNum);

        if (spawnPerSecondRate >= 0.2f) {
            spawnPerSecondRate -= Time.deltaTime;
        }
	}

	void MakeSprite(int num) {
        GameObject newBall = Instantiate(generiBall, transform.position, Quaternion.identity); 
        switch (num) {
            case 0:
                newBall.AddComponent<GreenBall>();
                newBall.GetComponent<SpriteRenderer>().sprite = greenBallSprite;
                break;
            case 1:
                newBall.AddComponent<BlueBall>();
                newBall.GetComponent<SpriteRenderer>().sprite = blueBallSprite;
                break;
            case 2:
                newBall.AddComponent<RedBall>();
                newBall.GetComponent<SpriteRenderer>().sprite = redBallSprite;
                break;
            case 3:
                newBall.AddComponent<YellowBall>();
                newBall.GetComponent<SpriteRenderer>().sprite = yellowBallSprite;
                break;
                
                
        }
        float newX = Random.Range(minBound.x, maxBound.x);
        float newY = Random.Range(minBound.y, maxBound.y);
        transform.position = new Vector3(newX, newY, 0f);
	}
}
