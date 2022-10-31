using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulationRunner : MonoBehaviour
{
    public Simulating[] simulating;

    float timer = 0.0f;
    bool started = false;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var item in simulating)
            {
                item.StartSimulation();
                started = true;
            }
        }

        if(started)
        {
            timer+=Time.deltaTime;

            foreach (var item in simulating)
            {
                item.UpdateSimulation(timer);
            }
        }
    }

    public void OnGameOver(GameOverStates state)
    {
        foreach (var item in simulating)
        {
            item.EndSimulation();
        }
        started = false;
    }
}
