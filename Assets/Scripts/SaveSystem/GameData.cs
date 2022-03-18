using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public int score = 0;
    public Dictionary<string, int> playerScores = new Dictionary<string, int>();

    public void AddScore(int points)
    {
        score += points;
    }
    public void ResetData()
    {
        score = 0;
    }
}
