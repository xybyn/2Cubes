using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Path
{
    struct PathSegment
    {
        public PathSegment(Vector3 p0, Vector3 p1)
        {
            _p0 = p0;
            _p1 = p1;
        }
        public Vector3 GetPosition(float t)
        {
            return Vector3.Lerp(_p0, _p1, t);
        }
        public float GetLength()
        {
            return (_p1-_p0).magnitude;
        }
        private Vector3 _p0;
        private Vector3 _p1;
    }
    private Queue<PathSegment> _segments = new Queue<PathSegment>();

    public Path(IList<Vector3> pathPoints)
    {
        for (int i = 0; i < pathPoints.Count - 1; i++)
        {
            _segments.Enqueue(new PathSegment(pathPoints[i], pathPoints[i+1]));
        }
        _lastPoint = pathPoints.Last();
    }
    private Vector3 _lastPoint;
    private List<Vector3> _pathPoints = new List<Vector3>();
    float prev = 0;
    public bool Ended()
    {
        return _segments.Count == 0;
    }
    public Vector3 GetPosition(float t)
    {
        if (_segments.Count == 0)
            return _lastPoint;
        float tau = (t-prev)/(_segments.Peek().GetLength());
        if(tau > 1.0f)
        {
            prev = t;
            _segments.Dequeue();
            if (_segments.Count == 0)
                return _lastPoint;
            tau = (t-prev)/(_segments.Peek().GetLength());
        }
        return _segments.Peek().GetPosition(tau);
    }
}
