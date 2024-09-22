using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject block;
    public float maxX;
    public Transform spawnPoint;
    public float spawnRate; // how fast we spawn the blocks

    bool gameStarted = false;

    public GameObject tapToStartImage;
    public TextMeshProUGUI scoreText;

    int score = 0;

    void Update() {
        
        if(Input.GetMouseButtonDown(0) && !gameStarted) { // first click down starts the game

            StartSpawning();
            gameStarted = true;
            tapToStartImage.SetActive(false);

        }


    }

    private void StartSpawning() {
        InvokeRepeating("SpawnBlock", 0.5f, spawnRate);
    }

    void SpawnBlock() {
        Vector3 spawnPos = spawnPoint.position;

        //random x axis
        spawnPos.x = Random.Range(-maxX, maxX);

        Instantiate(block, spawnPos, Quaternion.identity); // quaternion (normal rotation)

        score++;

        scoreText.text = score.ToString(); // update the score text

    }


}
