using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventScript : MonoBehaviour {

    public PlayerCombatScript combatScript;
	// Use this for initialization
	void Start () {
		
	}
	
    public void DeflectReset()
    {
        combatScript.DeflectReset();
    }

    public void TailDeflect(int dir)
    {
        combatScript.TailDeflect(dir);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
