using UnityEngine;
using System.Collections;

public class VictoryLevel : BattlegroundData {
    public Canvas victoryui;
    public string inputkey;
    public Object nextScene;

	void Start () {
	
	}
	public override GameObject SetupCombat()
    {
        cutsceneMScript = cutsceneManager.GetComponent<CutsceneManager>();
        gamemanager = GameObject.FindGameObjectWithTag("manager").GetComponent<Game>();
        turnmanager = GameObject.FindGameObjectWithTag("turn").GetComponent<TurnManager>();
        spawnbeacon = GetComponentInChildren<PlayerSpawner>();
        turnmanager.GetComponent<TurnManager>().currentarena = this.gameObject;
        //combatcamera.transform.position = this.transform.position + new Vector3(0, 0, -10);
        cutsceneMScript.BeginFade(-1);
        spawnbeacon.Victory();
        levelManager.EndofDungeon(victoryui, nextScene.name);
        return player;
    }
	

}
