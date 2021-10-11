using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.IO;

public class MainUIHighScore : MonoBehaviour
{
    public TextMeshProUGUI[] highScoreTable = new TextMeshProUGUI[5];
    int indexTable;
    // Start is called before the first frame update
    void Start()
    {
        LoadHighScore();
        UpdateHighScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateHighScore()
    {
        for (int i = 0; i < HighScore.highScoresList.Count; i++)
        {
            indexTable = HighScore.highScoresList.Count - 1 - i;
            highScoreTable[i].text = (i+1) + ". " + HighScore.highScoresList[indexTable].name + " Score: " + HighScore.highScoresList[indexTable].score ;
        }
    }

    [System.Serializable]
    class SaveData
    {
        public int highestScore;
        public string highScoreName;
        public List<Scores> highScoresList;
    }

    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            Debug.Log("json files " + json);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            HighScore.highScore = data.highestScore;
            HighScore.highScoreName = data.highScoreName;
            HighScore.highScoresList = data.highScoresList;
        }
    }
}
