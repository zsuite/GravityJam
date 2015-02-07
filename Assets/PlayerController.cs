using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed = 100;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.AddRelativeForce(new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical")) * speed * Time.deltaTime);
		
	}
}
