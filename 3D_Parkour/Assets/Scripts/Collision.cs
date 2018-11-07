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
        l0 = GameObject.Find("Level 0").GetComponent<Level>();
        levelT = l0.getLevelTimer();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        gm.RespawnPlayer(other.gameObject);
        levelT.resetTimer();
    }
}
