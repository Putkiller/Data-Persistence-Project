using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class HighScore : MonoBehaviour
{
    public static HighScore Instance;

    public static int highScore;
    public static string highScoreName;

    public static string playerName;
    public static int playerScore;

    //variables for organizing high score list:

    public static List<Scores> highScoresList = new List<Scores>();
    
    
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void CheckHighScore()
    {


        if (playerScore > highScore)
        {
            highScore = playerScore;
            highScoreName = playerName;
        }

    }

    public static void HighScoreList()
    {
        highScoresList.Add(new Scores(playerScore, playerName));

        //check the high score and rearrange
        highScoresList.Sort();
        
        

        //remove the other high score that is lower than top 5
        if(highScoresList.Count > 5)
        {
            highScoresList.RemoveAt(0);
        }

        for (int i = 0; i < highScoresList.Count; i++)
        {
            print(highScoresList[i].score + " " + highScoresList[i].name);
        }

            return;
    }

    

}
