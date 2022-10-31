using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicObstacle : Simulating
{
    public override void UpdateSimulation(float time)
    {
        float y = Mathf.Clamp(Mathf.Sin(time * Mathf.Deg2Rad * 100.0f)-1, -1.1f, 1.0f);
        transform.localPosition= new Vector3(transform.localPosition.x, y, transform.localPosition.z);
    }

    public override void StartSimulation()
    {
    }

    public override void EndSimulation()
    {
    }
}
