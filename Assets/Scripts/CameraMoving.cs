using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraMoving : MonoBehaviour
{
    // Start is called before the first frame update
    float phi = 45.0f;
    float ksi = 45.0f;
    float distance = 50.0f;
    float minDistance = 25.0f;
    float maxDistance = 60.0f;
    float k = 0.5f;

    Vector3 _prevMousePosition = new Vector3();
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _prevMousePosition = Input.mousePosition;
        }
        if (Input.GetMouseButton(1))
        {
            Vector3 delta = Input.mousePosition - _prevMousePosition;
            phi-=delta.x;
            ksi-=delta.y;
            ksi = Mathf.Clamp(ksi, -45, 80);
            _prevMousePosition = Input.mousePosition;
        }

        float scrollY = Input.mouseScrollDelta.y;
        k -=scrollY * Time.deltaTime * 4 ;
        k = Mathf.Clamp01(k);
        distance=  Mathf.Lerp(minDistance, maxDistance, k);

        float x = distance * Mathf.Cos(phi * Mathf.Deg2Rad) * Mathf.Cos(ksi * Mathf.Deg2Rad);
        float z = distance * Mathf.Sin(phi * Mathf.Deg2Rad) * Mathf.Cos(ksi * Mathf.Deg2Rad);
        float y = distance * Mathf.Sin(ksi * Mathf.Deg2Rad);

        transform.position = new Vector3(x, y, z);
        transform.LookAt(new Vector3(0, 0, 0));
    }
}
