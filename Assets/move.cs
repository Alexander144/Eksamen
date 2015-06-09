using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	private Vector3 _velocity = new Vector3(10f,10f);
	private Vector3 _position;
	// Use this for initialization
	void Awake () {
		_position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		_position += _velocity * Time.deltaTime;
	}
}
