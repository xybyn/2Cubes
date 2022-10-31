using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathConstructor : MonoBehaviour
{
    public PathBuilder redBuilder;
    public PathBuilder blueBuilder;

    private void Start()
    {
    }

    PathBuilder currentBuilder = null;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(rayOrigin, out hit))
            {
                if (hit.collider.CompareTag("Ground"))
                {
                    currentBuilder?.AddPoint(hit.point);
                }
            }
        }
    }

    public void OnCubeChanged(CubeTypes type)
    {
        switch (type)
        {
            case CubeTypes.RED_CUBE:
                currentBuilder = redBuilder;
                break;
            case CubeTypes.BLUE_CUBE:
                currentBuilder = blueBuilder;
                break;
            default:
                break;
        }
    }
}
