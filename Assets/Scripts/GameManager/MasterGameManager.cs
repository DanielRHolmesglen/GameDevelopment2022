using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterGameManager : MonoBehaviour
{
    //Set up a signleton
    public static MasterGameManager instance;
    private void Awake()
    {
        #region Singleton pattern
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        #endregion
    }
    //get a blank save file. This can be overriden by loading 
    GameData saveData = new GameData();

    public string LevelToPlay;
    public List<string> playersNames = new List<string>();
    public int numberOfPlayers;
    public int roundTime;
    public int killLimit;
}
