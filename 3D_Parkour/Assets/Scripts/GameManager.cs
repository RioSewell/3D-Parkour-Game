using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    List<string> levelList;

    LevelTimer levelT;
    public GameObject playerPrefab;


	// Use this for initialization
	void Start () {
        // levelT = GetComponent<LevelTimer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void LevelComplete()
    {
        //float completedTime = levelT.getTime();
        //Debug.Log(completedTime);
    }

    void getNextLevel()
    {

    }

    public void RespawnPlayer(GameObject p)
    {
        Transform playerRoot = p.transform.root;
        Destroy(playerRoot.gameObject);
        Instantiate(playerPrefab);
    }
}