using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float moveSpeed = 15;
	public float jumpHeight = 150;
	private Vector3 moveDirection;


	void Update() {
		moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical")).normalized;
		if(Input.GetButtonDown("Jump")){
			rigidbody.AddRelativeForce(0,jumpHeight,0);
		}

	}

	void FixedUpdate() {
		rigidbody.MovePosition(rigidbody.position + transform.TransformDirection(moveDirection) * moveSpeed * Time.deltaTime);
	}
}
