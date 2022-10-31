using UnityEngine;

public class UIGameOver : MonoBehaviour
{
    [SerializeField]
    private TMPro.TextMeshProUGUI _finalScoreText;
    [SerializeField]
    private TMPro.TextMeshProUGUI _loseWonText;
    [SerializeField]
    private ScoreCounter _scoreCounter;

    private void OnEnable()
    {
        _finalScoreText.SetText($"Coins {_scoreCounter.Score}");
    }

    public void OnGameOver(GameOverStates state)
    {
        switch (state)
        {
            case GameOverStates.ALL_FINISHED:
                _loseWonText.SetText("You won!!!");
                break;
            case GameOverStates.NOT_REACHED:
                break;
            case GameOverStates.DEAD:
                _loseWonText.SetText("You lose :(");
                break;
            default:
                break;
        }

        _finalScoreText.SetText($"Coins {_scoreCounter.Score}");
    }

}
