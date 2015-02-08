using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]
public class FauxGravityBody : MonoBehaviour {

	FauxGravityAttractor attractor;
	private Transform myTransform;
	GameObject Map;

	//had to manually select the celestial body gameobject because an instantiated prefab (the bullets) needs to use this script. 
	//Can't just drag it into a prefab unfortuantely.
	void Start () {
		//now uses the world tag to find him. 
		Map = GameObject.FindGameObjectWithTag ("World");
		rigidbody.useGravity = false;
		rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
		attractor = (FauxGravityAttractor) Map.GetComponent (typeof(FauxGravityAttractor));
		myTransform = transform;
	}

	void FixedUpdate () {
		if (attractor){
			attractor.Attract(myTransform);
		}
	}
	
}
