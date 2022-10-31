using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Simulating : MonoBehaviour
{
    public abstract void UpdateSimulation(float time);
    public virtual void StartSimulation()
    {
        isSimulating = true;
    }
    public virtual void EndSimulation()
    {
        isSimulating = false;
    }

    protected bool isSimulating = false;
}
