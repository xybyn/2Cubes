using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FinishedCounter : MonoBehaviour
{
    public int maxCountOfCubes = 2;
    public int countOfFinished = 0;
    public UnityEvent<GameOverStates> OnAllFinished = new UnityEvent<GameOverStates>();
    private bool invoked = false;
    public void OnFinished()
    {
        if (invoked)
            return;
        countOfFinished++;
        if (countOfFinished == maxCountOfCubes)
        {
            OnAllFinished.Invoke(GameOverStates.ALL_FINISHED);
            print("all finished");
            invoked = true;
        }
    }
}
