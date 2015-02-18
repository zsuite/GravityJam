using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float moveSpeed = 15;
	public float jumpHeight = 150;
	private Vector3 moveDirection;
	public GameObject bullet;
	public int maxHealth = 3;
	int health;
	//the place form which the person shoots. Will be a bit lower than his own position so it can be seen.
	public Transform shotLocation;

	void Start(){
		//sets initial health to max health.
		health = maxHealth;
	}

	void Update() {
		//sets the shotlocation to just in front of you
//		shotLocation = new Vector3 (transform.localPosition.x, transform.localPosition.y +1, transform.localPosition.z + 1.3f);
		Movement ();
		Shoot ();
	}

	void FixedUpdate() {
		KeepPosition ();
	}

	//Keeps position relative to sphere (i think, zach made this code)
	void KeepPosition(){
		rigidbody.MovePosition(rigidbody.position + transform.TransformDirection(moveDirection) * moveSpeed * Time.deltaTime);
	}

	//controls movement
	void Movement(){
		moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical")).normalized;
		if(Input.GetButtonDown("Jump")){
			rigidbody.AddRelativeForce(0,jumpHeight,0);
		}
	}

	//Instantiates a bullet at the players location and sets its velocity forward. 
	void Shoot(){
		if (Input.GetButtonDown("Fire1")) {
			GameObject b = Instantiate (bullet, shotLocation.position, transform.GetChild(0).rotation) as GameObject;
			//Moved the velocity part ot the BulletController script. 
		}
	}

	//For when colliding with a bullet (and maybe other objects later)
	//On trigger enter is called whenever it collides with a trigger. 
	void OnTriggerEnter(Collider bullet) {
		//makes sure what you were hit with is a projectile
		if (bullet.tag == "Projectile") {
			//destroys whatever collided with it
			Destroy (bullet.gameObject);
			//lowers health
			health--;
		}
	}

	//right now just kills you if you have no health. 
	//In the future health bars if applicable will prolly go here, idk.
	void HealthManager(){
		if (health > 1) {
			Destroy (gameObject);
		}
	}
}
