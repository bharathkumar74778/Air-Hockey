using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	public int playerNumber;
	public float speed;

	private Rigidbody paddleRigidbody;

	// Use this for initialization
	void Start () {
		paddleRigidbody = gameObject.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		float horizontalMovement = Input.GetAxis ("Horizontal" + playerNumber) * speed;
		float verticalMovement = Input.GetAxis ("Vertical" + playerNumber) * speed;

		paddleRigidbody.velocity = new Vector3 (horizontalMovement, 0, verticalMovement);
	}
}
