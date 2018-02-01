using UnityEngine;
using System.Collections;

public class Caster : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Ray downRay = new Ray (transform.position, -transform.up);
		RaycastHit hit;
		Debug.DrawRay (downRay.origin, downRay.direction * 10);

		if(Physics.Raycast(downRay, out hit, 10)){
			// far value, it will be ten, close will be zero
			// when the hit is a full ten meters away, it will be zero
			// when the hit is very close to zero, the value will be one
			float normDistance = (10.0f - hit.distance) / 10.0f;
			Color color = new Color(normDistance, 0.0f ,1.0f - normDistance);
			renderer.material.color = color;
		}
	}
}
