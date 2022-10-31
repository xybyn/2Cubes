using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreCounter : MonoBehaviour
{
    public int Score => score;
    private int score = 0;
    public UnityEvent<int> OnNewScore = new UnityEvent<int>();
    public void OnCoinPicked()
    {
        score++;
        OnNewScore.Invoke(score);
    }
}
