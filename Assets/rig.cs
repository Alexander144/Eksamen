using UnityEngine;
using System.Collections;

public class rig : MonoBehaviour {
	
	public KeyCode left;
	public KeyCode right;
	public int speed = 1;
	public static float trans;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(left) && transform.eulerAngles.z<303) {
			transform.Rotate(0,0,speed);
		} 
		else if (Input.GetKey(right)&& transform.eulerAngles.z>63) {
			transform.Rotate(0,0,-speed);
		} 
		trans = transform.eulerAngles.z;
	}
}
