using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {

    public float goalTime = 30.0f;
    public int levelNum;
    float bestTime = 1000.0f;
    LevelTimer levelT;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        levelT = GetComponent<LevelTimer>();
    }

    public float getGoalTime()
    {
        return goalTime;
    }
    public int getLevelNum()
    {
        return levelNum;
    }
    public float getBestTime()
    {
        return bestTime;
    }
    public void setBestTime(float t)
    {
        bestTime = t;
    }
    public void setGoalTime(float t)
    {
        goalTime = t;
    }
    public LevelTimer getLevelTimer()
    {
        return levelT;
    }
}
