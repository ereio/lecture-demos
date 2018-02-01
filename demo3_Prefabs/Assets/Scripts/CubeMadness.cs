using UnityEngine;
using System.Collections;

public class CubeMadness : MonoBehaviour {

	public GameObject rPrefab; // red prefab
	public GameObject bPrefab; // blue prefab
	// Use this for initialization
	void Start () {
		// Quaternion.identity - means no rotation

		for (int i = 0; i < 20; i++)
			for (int j = 0; j < 20; j++)
				for (int k = 0; k < 20; k++){

				int random = Random.Range(0,3);
	
				if(random == 0){
					Instantiate (rPrefab, new Vector3(-10 + i, -10 + j,-10 + k), Quaternion.identity);
				} else if(random == 1) {
					Instantiate (bPrefab, new Vector3(-10 + i, -10 + j,-10 + k), Quaternion.identity);
				} else {

				}
			}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
