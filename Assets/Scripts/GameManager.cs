using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public bool gameOver;

    public float score;
    public Text scoreText;
    public Text gameOverText;

    public GameObject obstacleSpawner;

    public GameObject gameOverPanel;
    public GameObject gamePanel;

	// Use this for initialization
	void Start ()
    {
        gameOver = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (gameOver)
        {
            gamePanel.SetActive(false);
            gameOverPanel.SetActive(true);
            obstacleSpawner.gameObject.SetActive(false);
            gameOverText.text = score.ToString("0");
        }
        else if(!gameOver)
        {
            score += Time.deltaTime;
            scoreText.text = score.ToString("0");
        }
	}
}
