using UnityEngine;
using System.Collections;

public class laser : MonoBehaviour {
	public KeyCode left;
	public KeyCode right;
	public KeyCode ctr;
	public GameObject storeball;
	public GameObject platform;
	public int spawn = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(ctr)&&Input.GetKey(left)&&spawn==0){
			spawn=1;
			Debug.Log("Shoot");
			GetComponent<Rigidbody2D> ().isKinematic = false;
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (-600,0));
			storeball.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (500,0));
			platform.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (500,0));
		}
		if(Input.GetKey(ctr)&&Input.GetKey(right)&&spawn==0){
			spawn=1;
			Debug.Log("Shoot");
			GetComponent<Rigidbody2D> ().isKinematic = false;
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (600,0));
			storeball.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (-500,0));
			platform.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (-500,0));
		}
	}
	void OnCollisionEnter2D (Collision2D other) {
		if(other.collider.tag == "dead"){
			spawn = 0;
			GetComponent<Rigidbody2D>().transform.localPosition = new Vector2(0.04f,-0.03451361f);
			GetComponent<Rigidbody2D> ().isKinematic = true;
		}
		if(other.collider.tag == "trekant"){
			Destroy(other.gameObject);
			spawn = 0;
			GetComponent<Rigidbody2D>().transform.localPosition = new Vector2(0.04f,-0.03451361f);
			GetComponent<Rigidbody2D> ().isKinematic = true;
		}
	}
}
