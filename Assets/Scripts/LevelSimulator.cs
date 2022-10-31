using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSimulator : Simulating
{
    public Simulating[] simulatings;

    public override void UpdateSimulation(float time)
    {
        foreach (var item in simulatings)
        {
            item.UpdateSimulation(time);
        }
    }
    public override void EndSimulation()
    {
        foreach (var item in simulatings)
        {
            item.EndSimulation();
        }
    }
    public override void StartSimulation()
    {
        foreach (var item in simulatings)
        {
            item.StartSimulation();
        }
    }
}
