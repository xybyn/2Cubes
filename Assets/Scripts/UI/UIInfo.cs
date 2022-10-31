using UnityEngine;

public class UIInfo : MonoBehaviour
{
    [SerializeField]
    private TMPro.TextMeshProUGUI _infoText;
    public void OnCubeChanged(CubeTypes type)
    {
        switch (type)
        {
            case CubeTypes.RED_CUBE:
                _infoText.SetText("Red");
                break;
            case CubeTypes.BLUE_CUBE:
                _infoText.SetText("Blue");
                break;
            default:
                break;
        }
    }
}
