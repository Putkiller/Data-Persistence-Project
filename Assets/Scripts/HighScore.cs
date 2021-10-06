using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public static HighScore Instance;

    public static int highScore;
    public static string highScoreName;

    public static string playerName;
    public static int playerScore;

    //variables for organizing high score list:
    [SerializeField]
    //List for name
    public List<string> playerNamesList = new List<string>();
    [SerializeField]
    //List for score
    public List<int> highScoresList = new List<int>();

    private void Awake()
   {
       if(Instance != null)
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
        for (int i = 0; i < 5; i++)
        {
            highScoresList.Add(i);
            playerNamesList.Add("Name: " + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void CheckHighScore()
    {
        

        if(playerScore > highScore)
        {
            highScore = playerScore;
            highScoreName = playerName;
        }
    }
        
    public void HighScoreList()
    {
        //check the high score and rearrange
        for (int i=0; i<5; i++)
        {
            if(highScoresList[i] < highScore)
            {
                highScoresList.Insert(i, highScore);
                playerNamesList.Insert(i, playerName);
            }
        }
        

        //remove the other high score that is lower than top 5
        if(highScoresList.Count > 5)
        {
            highScoresList.RemoveRange(5, highScoresList.Count - 5);
            playerNamesList.RemoveRange(5, playerNamesList.Count - 5);
        }

        return;
    }
    
}
