using UnityEngine;
using System.Collections;

public class MouseDrag : MonoBehaviour {
	
	void OnMouseDrag(){
		RaycastHit hitInfo;
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		Debug.DrawRay (ray.origin, ray.direction * 100);

		// LayerMask.NameToLayer ("Ground") - 8th bit
		if (Physics.Raycast 
		   (ray, out hitInfo, 100, (1 << 8))) {
			transform.position = new Vector3(hitInfo.point.x, transform.position.y, hitInfo.point.z);
		}
	}
}
