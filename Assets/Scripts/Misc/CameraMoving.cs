using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    private float _phi = 45.0f;
    private float _ksi = 45.0f;
    private float _distance = 50.0f;
    private float _minDistance = 25.0f;
    private float _maxDistance = 60.0f;
    private float _distanceCoeff = 0.5f;
    private Vector3 _prevMousePosition = new Vector3();

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _prevMousePosition = Input.mousePosition;
        }
        if (Input.GetMouseButton(1))
        {
            Vector3 delta = Input.mousePosition - _prevMousePosition;
            _phi-=delta.x;
            _ksi-=delta.y;
            _ksi = Mathf.Clamp(_ksi, -45, 80);
            _prevMousePosition = Input.mousePosition;
        }

        float scrollY = Input.mouseScrollDelta.y;
        _distanceCoeff -=scrollY * Time.deltaTime * 4;
        _distanceCoeff = Mathf.Clamp01(_distanceCoeff);
        _distance=  Mathf.Lerp(_minDistance, _maxDistance, _distanceCoeff);

        float x = _distance * Mathf.Cos(_phi * Mathf.Deg2Rad) * Mathf.Cos(_ksi * Mathf.Deg2Rad);
        float z = _distance * Mathf.Sin(_phi * Mathf.Deg2Rad) * Mathf.Cos(_ksi * Mathf.Deg2Rad);
        float y = _distance * Mathf.Sin(_ksi * Mathf.Deg2Rad);

        transform.position = new Vector3(x, y, z);
        transform.LookAt(new Vector3(0, 0, 0));
    }
}
