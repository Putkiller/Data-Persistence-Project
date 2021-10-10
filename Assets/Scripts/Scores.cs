using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class Scores : IComparable<Scores>
{
    public int score;
    public string name;

    public Scores(int newScore, string newName)
    {
        name = newName;
        score = newScore;
    }

    public int CompareTo(Scores other)
    {
        if (other == null)
        {
            return 1;
        }

        //Return the difference
        return score - other.score;
    }
}
