using UnityEngine;

public class LevelSimulator : Simulating
{
    [SerializeField]
    private Simulating[] _simulatings;

    public override void UpdateSimulation(float time)
    {
        foreach (var item in _simulatings)
        {
            item.UpdateSimulation(time);
        }
    }
    public override void EndSimulation()
    {
        foreach (var item in _simulatings)
        {
            item.EndSimulation();
        }
    }
    public override void StartSimulation()
    {
        foreach (var item in _simulatings)
        {
            item.StartSimulation();
        }
    }
}
