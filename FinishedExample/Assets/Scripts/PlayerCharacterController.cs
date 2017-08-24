using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterController : MonoBehaviour {

    float maxSpeed = 10f;
    float movement = 0f;
    bool facingRight = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float move = Input.GetAxis("Horizontal");

        Rigidbody2D rigidbody = this.GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(move * maxSpeed, rigidbody.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(new Vector2(0f, 700f));
        }

        if (move > 0f && !facingRight)
        {
            Flip();
        }
        else if (move < 0f && facingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
