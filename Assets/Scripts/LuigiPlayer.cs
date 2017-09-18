using UnityEngine;
using System.Collections;

public class LuigiPlayer : MonoBehaviour {
	Rigidbody rigidbody;
	public bool Midair = false;
	public float JumpHeight = 10f;
	float dist;
	Vector3 dir;
	RaycastHit hit;


	// Use this for initialization
	void Start () {
		rigidbody = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		float dist = 1.7f;
		Vector3 dir = new Vector3 (0, -1, 0);
		
		//edit: to draw ray also//
		Debug.DrawRay (transform.position, dir * dist, Color.green);
		//end edit//

		if (Physics.Raycast (transform.position, dir, dist)) 
		{
		Midair = false;
		} 
		else {
		}
	}
	void FixedUpdate (){
		if (Input.GetKeyDown (KeyCode.W) && !Midair) 
		{
			rigidbody.velocity = new Vector3(0, JumpHeight ,0);
			Midair = true;
			Debug.Log ("Jump");
		}

	}
		public void Jump()
		{
			//Jumping mechanics


	}

}