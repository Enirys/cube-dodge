using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameManager gameManager;

    public GameObject deathEffect;

    public float deathY;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Death();
        }
    }

    private void Update()
    {
        if(transform.position.y < deathY)
        {
            Death();
        }
    }

    private void Death()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        gameManager.gameOver = true;
        gameObject.SetActive(false);
    }
}
