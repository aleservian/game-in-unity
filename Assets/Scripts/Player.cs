using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed = 5f;
	public int jumpForce;
	public int health;
	public Transform groundCheck;

	private bool invunerable = false;
	private bool grounded = false;
	private bool jumping = false;
	private bool facingRight = true;

	private SpriteRenderer sprite;
	private Rigidbody2D rb2d;
	private Animator anim;

	// Use this for initialization
	void Start () {
		sprite = GetComponent<SpriteRenderer>();
		rb2d = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate(){
		float move = Input.GetAxis("Horizontal");
		rb2d.velocity = new Vector2(move * speed, rb2d.velocity.y);
		if((move < 0f && facingRight) || (move > 0f && !facingRight)){
			Flip();
		}
	}

	void Flip(){
		facingRight = !facingRight;
		transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
	}
}
