using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScore : MonoBehaviour
{
    public TMPro.TextMeshProUGUI score;
    public void OnNewScore(int newScore)
    {
        score.SetText($"Coins: {newScore}");
    }
}
