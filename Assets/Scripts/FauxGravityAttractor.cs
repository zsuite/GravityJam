using UnityEngine;
using System.Collections;

public class FauxGravityAttractor : MonoBehaviour {
	//changed it to 30 so bullets could go faster. Updated other thing proportionally as well.
	public float gravity = -30;

	public void Attract(Transform body) {
		Vector3 gravityUp = (body.position - transform.position).normalized;
		Vector3 localUp = body.up;

		body.rigidbody.AddForce(gravityUp * gravity);

		Quaternion targetRotation = Quaternion.FromToRotation(localUp,gravityUp) * body.rotation;
		body.rotation = Quaternion.Slerp(body.rotation,targetRotation,50f * Time.deltaTime );
	}   

}
