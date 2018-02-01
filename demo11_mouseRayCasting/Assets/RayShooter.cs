using UnityEngine;
using System.Collections;

public class RayShooter : MonoBehaviour {
	public GameObject prefab;

	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0)){
			Ray screenRay = camera.ScreenPointToRay(Input.mousePosition);
			Debug.DrawRay(screenRay.origin, screenRay.direction * 20, Color.cyan, 0.2f);
			GameObject projectile = (GameObject) Instantiate(prefab, screenRay.origin, Quaternion.identity);
			projectile.rigidbody.AddForce(screenRay.direction * 500.0f);		
		}
	}
}
