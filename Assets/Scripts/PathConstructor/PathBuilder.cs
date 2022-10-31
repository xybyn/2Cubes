using System.Collections.Generic;
using UnityEngine;

public class PathBuilder : MonoBehaviour
{

    [SerializeField]
    private Transform _startPoint;
    [SerializeField]
    private Transform _endPoint;
    [SerializeField]
    private GameObject _markPrefab;

    private List<Vector3> _points = new List<Vector3>();
    private List<GameObject> _prefabs = new List<GameObject>();

    public Path CreatePath()
    {
        _points.Add(_endPoint.position);
        return new Path(_points);
    }

    public void Clear()
    {
        _points.Clear();
        foreach (var item in _prefabs)
        {
            Destroy(item.gameObject);
        }
        _prefabs.Clear();
    }

    private void Start()
    {
        _points.Add(_startPoint.position);
    }
    public void AddPoint(Vector3 point)
    {
        _prefabs.Add(Instantiate(_markPrefab, point, Quaternion.identity));
        _points.Add(point + Vector3.up * 0.51f);
    }
}
