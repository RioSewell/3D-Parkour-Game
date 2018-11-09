using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

    Vector3 SpawnPoint = new Vector3(0, 2.05f, 0);
    Rigidbody rb;
    Level l0;
    LevelTimer levelT;
    GameManager gm;

    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        string thislevel = gm.getActiveScene();

        l0 = GameObject.Find(thislevel).GetComponent<Level>();
        levelT = l0.getLevelTimer();
      
    }

    private void OnTriggerEnter(Collider other)
    {
        gm.RespawnPlayer(other.gameObject);
        levelT.resetTimer();
    }
}
