using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    int levelCounter = 0;
    LevelTimer levelT;
    public GameObject playerPrefab;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }


    // Use this for initialization
    void Start () {
        // levelT = GetComponent<LevelTimer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void LevelComplete()
    {
        levelCounter++;
        SceneManager.LoadScene(levelCounter);
        RespawnPlayer(playerPrefab);
        //float completedTime = levelT.getTime();
        //Debug.Log(completedTime);
    }

    void getNextLevel()
    {

    }

    public string getActiveScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        return scene.name;
    }

    public void RespawnPlayer(GameObject p)
    {
        Debug.Log("Respawning Player");
        Transform playerRoot = p.transform.root;
        Destroy(playerRoot.gameObject);
        Instantiate(playerPrefab);
    }
}