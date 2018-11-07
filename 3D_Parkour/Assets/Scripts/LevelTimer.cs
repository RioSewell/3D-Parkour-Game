using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTimer : MonoBehaviour {

    float startTime;
    float timeTaken;

	// Use this for initialization
	void Start () {
        resetTimer();
	}
	
	// Update is called once per frame
	void Update () {
        timeTaken = Time.time - startTime;
	}

    public void resetTimer()
    {
        timeTaken = 0;
        startTime = Time.time;
    }

    public float getTime()
    {
        return timeTaken;
    }
}
