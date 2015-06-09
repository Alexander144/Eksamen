using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {
	public KeyCode space;
	public static int shoot = 0;
	public float power;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(space)){
			power +=2;
			Debug.Log(power);
		}
		if (Input.GetKeyUp (space) && rig.trans > 181 && shoot == 0) {
			GetComponent<Rigidbody2D> ().isKinematic = false;
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (-(power) + (rig.trans), power));
			shoot = 1;
			power = 0;
		} else if (Input.GetKeyUp (space) && rig.trans < 181 && shoot == 0) {
			GetComponent<Rigidbody2D> ().isKinematic = false;
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 ((power) + (rig.trans), power));
			shoot = 1;
			power = 0;
		}
	}
}