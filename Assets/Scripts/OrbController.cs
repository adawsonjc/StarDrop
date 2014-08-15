using UnityEngine;
using System.Collections;

public class OrbController : MonoBehaviour {

	public float moveSpeed;
	private Vector3 target;

	void Start () {
		target=transform.position;
	}

	void Update () {
		Vector3 currentPosition = transform.position;

		if( Input.GetButton("Fire1") ) {
			Vector3 mouseInput=Camera.main.ScreenToWorldPoint( Input.mousePosition );
			target = mouseInput;
			target.z=0;
		}

		if (currentPosition != target) {
			transform.position = Vector3.Lerp (currentPosition, target, 0.5f);
		}


}
}