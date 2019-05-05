using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FlyLittleBird : MonoBehaviour {

	public float velocity = 1;
	public Rigidbody2D rb;
	private bool tapped = false;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			tapped = true;
		} else { tapped = false; }
	}

	void FixedUpdate () {
		if (tapped == true) {
			rb.velocity = Vector2.up * velocity;
		}
	}
}
