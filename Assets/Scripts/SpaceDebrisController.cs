using UnityEngine;
using System.Collections;

public class SpaceDebrisController : MonoBehaviour {

	public GameObject spaceDebris;

	// Use this for initialization
	void Start () {
		GameObject spaceDebris01=(GameObject) Instantiate (spaceDebris);

		//instantiate at random position
		//Instantiate (spaceDebris, new Vector2 (1, 0), new Quaternion());

		spaceDebris01.rigidbody2D.AddForce (new Vector2 (100, -100));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
