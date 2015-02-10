using UnityEngine;
using System.Collections;

//Basically this will be used to determine how long bullets live and how fast they go. 
public class BulletController : MonoBehaviour {
	//movement speed
	public int moveSpeed = 30;
	float timer;
	public int DeathTime = 7;

	// Use this for initialization
	void Start () {
		//sets initial velocity
		gameObject.rigidbody.velocity = transform.forward * moveSpeed;
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		//Using time.deltatime like this will increase timer by 1 every second. 
		timer += Time.deltaTime;
		Death ();
	
	}
	//sets a timer with time.delta time and then destroys the bullet after DeathTime seconds. 
	void Death() {
		if (timer > DeathTime){
			Destroy (gameObject);
		}
	}

	//this will make the bullet die whenever it collides with anything. 
	void OnTriggerEnter (Collider thing){
		//the player controller script kills the buillets any ways in its on trigger enter script. 
		//This is to avoid order issues
		if (thing.tag == "Obstacle") {
			Destroy (gameObject);
		}
	}
}
