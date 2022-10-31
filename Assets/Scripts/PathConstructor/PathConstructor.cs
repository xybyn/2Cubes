using UnityEngine;

public class PathConstructor : MonoBehaviour
{
    [SerializeField]
    private PathBuilder _redBuilder;
    [SerializeField]
    private PathBuilder _blueBuilder;

    private PathBuilder _currentBuilder = null;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(rayOrigin, out hit))
            {
                if (hit.collider.CompareTag("Ground"))
                {
                    _currentBuilder?.AddPoint(hit.point);
                }
            }
        }
    }

    public void OnCubeChanged(CubeTypes type)
    {
        switch (type)
        {
            case CubeTypes.RED_CUBE:
                _currentBuilder = _redBuilder;
                break;
            case CubeTypes.BLUE_CUBE:
                _currentBuilder = _blueBuilder;
                break;
            default:
                break;
        }
    }
}
