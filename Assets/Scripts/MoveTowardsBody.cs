using UnityEngine;
using System.Collections;

public class MoveTowardsBody : MonoBehaviour {
	public Transform target;
	public float gravityNum = 100f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 gravityDirection = target.position - transform.position;
		transform.up = -gravityDirection;

		rigidbody.AddForce(gravityDirection.normalized * gravityNum * Time.fixedDeltaTime);
	}
}
