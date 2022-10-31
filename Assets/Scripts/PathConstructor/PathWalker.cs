using UnityEngine;

public class PathWalker : Simulating
{
    [SerializeField]
    private PathBuilder _pathBuilder;

    private Path _path;
    public override void StartSimulation()
    {
        base.StartSimulation();
        _path = _pathBuilder.CreatePath();
    }
    public override void UpdateSimulation(float time)
    {
        if (isSimulating)
        {
            time += Time.deltaTime;

            Vector3 position = _path.GetPosition(time * 10);
            transform.position = position;
        }
    }
    public override void EndSimulation()
    {
        base.EndSimulation();
        _pathBuilder.Clear();
    }
}
