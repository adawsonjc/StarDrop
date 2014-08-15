using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	private float startTime;
	private float elapsedTime;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		elapsedTime = Time.time - startTime;
	}

	void OnGUI(){
		GUI.Label(new Rect(0, 0, 100, 100), (elapsedTime.ToString()));
	}

	public int getTime(){
		return (int) elapsedTime;
	}
}
