using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    private float moveSpeed;

    private Rigidbody rb;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();	
	}
	
	// Update is called once per frame
	void Update ()
    {
        float moveH = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(moveH * moveSpeed, rb.velocity.y, rb.velocity.z);
	}
}
