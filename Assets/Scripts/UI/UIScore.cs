using UnityEngine;

public class UIScore : MonoBehaviour
{
    [SerializeField]
    private TMPro.TextMeshProUGUI _score;
    public void OnNewScore(int newScore)
    {
        _score?.SetText($"Coins: {newScore}");
    }
}
