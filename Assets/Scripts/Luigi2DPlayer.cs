using UnityEngine;
using System.Collections;

public class Luigi2DPlayer : MonoBehaviour {

	public bool Grounded;
	public float JumpSpeed;
	public Animator anim;
	public Rigidbody2D rigidbody;
	int jumpHash = Animator.StringToHash("Jump");


	void Start () {
		JumpSpeed = 23;
		anim = GetComponent<Animator> ();
		rigidbody = GetComponent<Rigidbody2D> ();
		Grounded = true;
		anim.SetBool ("Grounded", Grounded);

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.W))
		{	
			Jump ();
		}

	}
	void FixedUpdate()
	{


		 }
	void Jump ()
	{
		if (Grounded == true) {
			rigidbody.AddForce(Vector2.up * (JumpSpeed), ForceMode2D.Impulse);
			anim.SetTrigger ("Jump");
			Debug.Log ("Jump");
		}
		if (!Grounded) {
			Debug.Log ("Fail");
}

}
}