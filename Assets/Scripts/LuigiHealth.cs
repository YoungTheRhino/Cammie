using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LuigiHealth : MonoBehaviour {
	public int Health;
	public Text MyHealth;
	public int MyMaxHealth;
	int healthHash = Animator.StringToHash("Health");

	private Animator anim;
	private LuigiPlayer luigimovement;
	private float timer;
	private bool LuigiDead;


	void Awake()
	{
		anim = GetComponent<Animator> ();
		luigimovement = GetComponent<LuigiPlayer> ();
	}

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () 
	{ 
		transform.localPosition = (Vector3.zero);
		MyHealth.text = Health.ToString()+ "/" + MyMaxHealth.ToString ();
		anim.SetInteger (healthHash, Health);
	}
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.CompareTag ("Enemy")) {

		}
	}
		public void TakeDamage(int playerdamage)
		{
		Health -= playerdamage;

}
	}