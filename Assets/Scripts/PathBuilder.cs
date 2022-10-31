using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PathBuilder : MonoBehaviour
{
    private List<Vector3> _points = new List<Vector3>();
    private List<GameObject> _prefabs = new List<GameObject>();
    public Transform startPoint;
    public Transform endPoint;
    public GameObject markPrefab;
    public Path CreatePath()
    {
        _points.Add(endPoint.position);
        Path p = new Path(_points);
        return p;
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
        _points.Add(startPoint.position);
    }
    public void AddPoint(Vector3 point)
    {
        _prefabs.Add(Instantiate(markPrefab, point, Quaternion.identity));
        _points.Add(point + Vector3.up * 0.51f);
    }
}
