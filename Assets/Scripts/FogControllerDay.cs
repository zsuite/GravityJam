using UnityEngine;
using System.Collections;

public class FogControllerDay : MonoBehaviour {

	//determins what time it is where the player is. 
	public bool isNight;
	//These should be the 4 child particle systems.
	public ParticleSystem fogCreator;
	public ParticleSystem fogCreator2;
	public ParticleSystem fogCreator3;
	public ParticleSystem fogCreator4;

	// Use this for initialization
	void Start () {
		//so it doesn't start with fog if not needed. 
		//Simply disabling the emission has it always start with some particals.
		fogCreator.renderer.enabled = false;
		fogCreator2.renderer.enabled = false;
		fogCreator3.renderer.enabled = false;
		fogCreator4.renderer.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
		makeFog ();
	}


	//This function starts or stops making the fog effect depending if it "is night" or not. 
	//As of now you have to toggle this bool manually but later it will be automatically turned on / off depending on time of day. 
	void makeFog(){
		if (isNight) {
			//Manually sets the renderer to true. 
			//This is only necessary the first time the particals are shown and probably shouldn't be in update 
			//but I didn't knwo where else to put this.
			fogCreator.renderer.enabled = true;
			fogCreator2.renderer.enabled = true;
			fogCreator3.renderer.enabled = true;
			fogCreator4.renderer.enabled = true;

			fogCreator.enableEmission = true;
			fogCreator2.enableEmission = true;
			fogCreator3.enableEmission = true;
			fogCreator4.enableEmission = true;
		}

		else {
			fogCreator.enableEmission = false;
			fogCreator2.enableEmission = false;
			fogCreator3.enableEmission = false;
			fogCreator4.enableEmission = false;
		}
	}
	
}
