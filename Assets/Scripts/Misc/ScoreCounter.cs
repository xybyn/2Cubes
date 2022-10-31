using UnityEngine;
using UnityEngine.Events;

public class ScoreCounter : MonoBehaviour
{
    public int Score => _score;
    public UnityEvent<int> OnNewScore = new UnityEvent<int>();

    private int _score = 0;
    public void OnCoinPicked()
    {
        _score++;
        OnNewScore.Invoke(_score);
    }
}
