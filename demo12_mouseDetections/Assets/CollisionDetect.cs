using UnityEngine;
using System.Collections;

public class CollisionDetect : MonoBehaviour {

	void OnCollisionEnter(Collision c){
		Debug.Log (name + " Collided");
	
	}

	void OnTriggerEnter(Collider c){
		Debug.Log (name + " Triggered");
	}
}
