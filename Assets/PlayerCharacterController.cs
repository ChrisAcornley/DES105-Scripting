using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterController : MonoBehaviour {

    float maxSpeed = 10f;
    float movement = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float move = Input.GetAxis("Horizontal");

        Rigidbody2D rigidbody = this.GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(move * maxSpeed, rigidbody.velocity.y);
    }
}
