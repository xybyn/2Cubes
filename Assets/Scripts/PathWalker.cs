using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PathWalker : Simulating
{
    public PathBuilder pathBuilder;

    Path path;
    public override void StartSimulation()
    {
        base.StartSimulation();
        path = pathBuilder.CreatePath();
    }
    public override void UpdateSimulation(float time)
    {
        if(isSimulating)
        {
            time += Time.deltaTime;
           
                Vector3 position = path.GetPosition(time * 10);
                transform.position = position;
        }
    }
    public override void EndSimulation()
    {
        base.EndSimulation();
        pathBuilder.Clear();
    }
}
