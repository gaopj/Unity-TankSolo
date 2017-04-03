using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour {
	public float speed = 5.0f;

	private Rigidbody rigidbody;
	// Use this for initialization
	void Start () {
		rigidbody = this.GetComponent<Rigidbody> ();
	}
		
	void FixedUpdate(){
		//float h = Input.GetAxis ("Horizontal");
		float h = Input.GetAxis ("Vertical");
		rigidbody.velocity = transform.forward*h*speed;
	}
}
