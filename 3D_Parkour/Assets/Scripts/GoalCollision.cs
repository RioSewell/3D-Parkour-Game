using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCollision : MonoBehaviour {

    Vector3 SpawnPoint = new Vector3(0, 2.05f, 0);
    Rigidbody rb;
    LevelTimer levelT;
    Level l0;
    GameManager gm;

    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        string thisLevel = gm.getActiveScene();
        Debug.Log(thisLevel);

        l0 = GameObject.Find(thisLevel).GetComponent<Level>();
        levelT = l0.getLevelTimer();
        
    }

    private void OnTriggerEnter(Collider other)
    {

        float t = levelT.getTime();

        if (t < l0.getBestTime())
        {
            l0.setBestTime(t);
            Debug.Log("New Best Time: "+t);

            if(t < l0.getGoalTime())
            {
                gm.LevelComplete();
                Debug.Log("Level Beaten! Good Job");
            }
        }
        else
        {
            Debug.Log("THis Attempt: " + t);
            Debug.Log("Gotta go Faster!");
            Debug.Log("Current Best Time: " + l0.getBestTime());
        }

        gm.RespawnPlayer(other.gameObject);
        levelT.resetTimer();
        

    }
}
