using UnityEngine;
using UnityEngine.Events;

public class FinishedCounter : MonoBehaviour
{

    public UnityEvent<GameOverStates> OnAllFinished = new UnityEvent<GameOverStates>();
    private bool _invoked = false;
    private int _maxCountOfCubes = 2;
    private int _countOfFinished = 0;
    public void OnFinished()
    {
        if (_invoked)
            return;
        _countOfFinished++;
        if (_countOfFinished == _maxCountOfCubes)
        {
            OnAllFinished.Invoke(GameOverStates.ALL_FINISHED);
            _invoked = true;
        }
    }
}
