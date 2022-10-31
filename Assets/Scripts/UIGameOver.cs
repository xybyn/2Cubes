using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UIGameOver : MonoBehaviour
{
    public TMPro.TextMeshProUGUI finalScoreText;
    public TMPro.TextMeshProUGUI loseWonText;

    public ScoreCounter scoreCounter;

    private void OnEnable()
    {
        finalScoreText.SetText($"Coins {scoreCounter.Score}");
    }
    public void OnGameOver(GameOverStates state)
    {
        switch (state)
        {
            case GameOverStates.ALL_FINISHED:
                loseWonText.SetText("You won!!!");
                break;
            case GameOverStates.NOT_REACHED:
                break;
            case GameOverStates.DEAD:
                loseWonText.SetText("You lose :(");
                break;
            default:
                break;
        }

        finalScoreText.SetText($"Coins {scoreCounter.Score}");
    }

}
