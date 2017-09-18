using UnityEngine;
using System.Collections;

public class spawnbeacon : MonoBehaviour {
    public GameObject playerprefab;
    public GameObject player;
    protected PlayerCombatScript playerscript;
    public BattlegroundData battleground;
    public LevelData levelData;
    // Use this for initialization
    void Start () {
        Debug.Log("SpawnBeacon Start");
   
    }


	public virtual GameObject Spawn()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            Debug.Log("Player Spawn");
            player = Instantiate<GameObject>(playerprefab);
            player.GetComponent<PlayerCombatVariables>().GetData();
            
        }
        else
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
        playerscript = player.GetComponent<PlayerCombatScript>();
        player.transform.position = this.transform.position;
        playerscript.incombat = true;
        playerscript.enabled = true;
        return player;
    }

    public void Victory()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        player.transform.position = this.transform.position;
    }
	// Update is called once per frame
	void Update () {
	
	}
}
