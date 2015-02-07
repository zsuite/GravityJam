using UnityEngine;
using System.Collections;

public class MoveTowardsBody : MonoBehaviour {
	public Transform target;
	public float gravityNum = 9.8f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 gravityDirection = transform.position - target.position;
		target.rigidbody.AddForce(gravityDirection.normalized * gravityNum * Time.fixedDeltaTime);
	}
}
