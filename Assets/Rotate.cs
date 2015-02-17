using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	public float rotateRate = 1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate(new Vector3(0,1f,0), rotateRate + Time.deltaTime);
	}


}
