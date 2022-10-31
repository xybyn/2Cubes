using UnityEngine;
using UnityEngine.Events;

public class GameFlow : MonoBehaviour
{
    public UnityEvent<GameOverStates> OnGameOver = new UnityEvent<GameOverStates>();
    public void OnGameFinished(GameOverStates state)
    {
        OnGameOver.Invoke(state);
    }
}
