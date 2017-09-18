using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceDrop : MonoBehaviour {

    public bool playerhit = false;
    PlayerCombatScript playerScript;
    GameObject playerObject;

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
    public void Release( PlayerCombatScript p)
    {
        playerScript = p;
        playerObject = playerScript.gameObject;
        StartCoroutine(Acquisition());
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        playerhit = true;
    }
    IEnumerator Acquisition()
    {
        while(!playerhit)
        {
            transform.position = Vector2.MoveTowards(transform.position, playerObject.transform.position + PlayerCombatScript.offset, speed);
            Debug.Log("Acquisition in progress");
            yield return null;
        }
        
        Debug.Log("Acquisition Done");
        Destroy(this.gameObject);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
