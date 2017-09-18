using UnityEngine;
using System.Collections;


public class LuigiBattleScript : MonoBehaviour {
	Animator animator;

	// Use this for initialization
	void Start () {
		LuigiHealth luigihealth = GetComponent<LuigiHealth>();
		animator = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
		LuigiHealth luigihealth = GetComponent<LuigiHealth>();
		int h = luigihealth.Health;

		animator.SetInteger ("Health", h);
	}
}
