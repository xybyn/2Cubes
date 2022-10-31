using UnityEngine;
using UnityEngine.Events;

public class CubeSelector : MonoBehaviour
{
    public UnityEvent<CubeTypes> OnCubeChanged = new UnityEvent<CubeTypes>();

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            OnCubeChanged.Invoke(CubeTypes.BLUE_CUBE);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            OnCubeChanged.Invoke(CubeTypes.RED_CUBE);
        }
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(rayOrigin, out hit))
            {
                if (hit.collider.CompareTag("BlueCube"))
                {
                    OnCubeChanged.Invoke(CubeTypes.BLUE_CUBE);
                }
                else if (hit.collider.CompareTag("RedCube"))
                {
                    OnCubeChanged.Invoke(CubeTypes.RED_CUBE);
                }
            }
        }
    }
}
