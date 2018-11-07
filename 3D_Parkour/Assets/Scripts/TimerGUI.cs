using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerGUI : MonoBehaviour {

    Text t;
    float getT;
    LevelTimer levelT;
    Level l0;

	// Use this for initialization
	void Start () {

        t = GetComponent<Text>();
        l0 = GameObject.Find("Level 0").GetComponent<Level>();
        levelT = l0.getLevelTimer();
	}
	
	// Update is called once per frame
	void Update () {

        t.text = "Time: " + levelT.getTime().ToString("F3") + "\n" + "Goal: " + l0.getGoalTime().ToString("F3") + "\n" + "Best:" + l0.getBestTime().ToString("F3");
	}


}
