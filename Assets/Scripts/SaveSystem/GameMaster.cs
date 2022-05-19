using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    GameData saveData = new GameData();


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //saveData.AddScore(1);
            PrintScore();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
           //// saveData.AddScore(-1);
            PrintScore();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            SaveSystem.instance.SaveGame(saveData);
            Debug.Log("Saved data.");
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            saveData = SaveSystem.instance.LoadGame();
            Debug.Log("Loaded data");
            PrintScore();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            //saveData.ResetData();
            PrintScore();
        }
    }

    public void SaveGame()
    {
        SaveSystem.instance.SaveGame(saveData);
    }
       public void PrintScore()
    {
        //Debug.Log("The current score is " + saveData.score);
    }

}
